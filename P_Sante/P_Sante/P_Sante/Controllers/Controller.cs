using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Sante.Views;
using P_Sante.Models;
using P_Sante.Classes;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin.Controls;
using System.Security.Cryptography;

namespace P_Sante.Controllers
{
    public class Controller
    {
        //attributes
        /// <summary>
        /// Login page
        /// </summary>
        private Login _aLogin;
        /// <summary>
        /// Register page
        /// </summary>
        private Registration _aRegistration;

        private Interests _aInterests;

        private MentalQuestions _aMentalQuestions;

        private PhysicalQuestions _aPhysicalQuestions;

        private Profile _aProfile;

        private DialogWindow _aDialog;

        private ModifyPassword _aModify;
        /// <summary>
        /// Model (db manager)
        /// </summary>
        private Model _aModel;

        private const string NAME_EX = @"^[A-Za-zÀ-ÖØ-öø-ÿ\- ']+$";

        private const string EMAIL_EX = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        private const string PASS_EX = @"^(?=.*\d)(?=.*[^a-zA-Z0-9,]).{12,}$";

        private const string WEIGHT_EX = @"^\d{1,3}$";

        private const int SALT_LENGTH = 40;

        /// <summary>
        /// Creates a new instance of Controller
        /// </summary>
        /// <param name="aLogin">Login page</param>
        /// <param name="aRegister">Register page</param>
        /// <param name="aModel">Model</param>
        public Controller(Login aLogin, Registration aRegister, Interests aInterests, MentalQuestions aMentalQuestions, PhysicalQuestions aPhysiqueQuestions, Profile aProfile, DialogWindow aDialog, ModifyPassword aModify, Model aModel)
        {
            _aLogin = aLogin;
            _aRegistration = aRegister;
            _aInterests = aInterests;
            _aMentalQuestions = aMentalQuestions;
            _aPhysicalQuestions = aPhysiqueQuestions;
            _aProfile = aProfile;
            _aDialog = aDialog;
            _aModify = aModify;
            _aModel = aModel;

            _aLogin.Controller = this;
            _aRegistration.Controller = this;
            _aInterests.Controller = this;
            _aMentalQuestions.Controller = this;
            _aPhysicalQuestions.Controller = this;
            _aProfile.Controller = this;
            _aDialog.Controller = this;
            _aModify.Controller = this;
            _aModel.Controller = this;
        }

        public void OpenRegistration(MaterialForm form)
        {
            _aRegistration.Location = new Point(form.Location.X, form.Location.Y);
            if(form is Profile)
            {
                _aRegistration.Modify = true;
            }
            _aRegistration.Show();
        }

        public void OpenLogin(MaterialForm form) 
        {
            _aLogin.Location = new Point(form.Location.X, form.Location.Y);
            _aLogin.Show();
        }

        public void OpenLogin()
        {
            _aLogin.Location = new Point(_aProfile.Location.X, _aProfile.Location.Y);
            _aLogin.Show();
        }

        public void OpenInterests(MaterialForm form) 
        {
            _aInterests.Location = new Point(form.Location.X, form.Location.Y);
            _aInterests.Show();
        } 

        public void OpenMentalQuestions(MaterialForm form)
        {
            _aMentalQuestions.Location = new Point(form.Location.X, form.Location.Y);
            if(form is Profile)
            {
                _aMentalQuestions.Modify = true;
            }
            _aMentalQuestions.Show();
        } 

        public void HideMentalQuestions() => _aMentalQuestions.Hide();

        public void OpenPhysicalQuestions(MaterialForm form)
        {
            _aPhysicalQuestions.Location = new Point(form.Location.X, form.Location.Y);
            if (form is Profile)
                _aPhysicalQuestions.Modify = true;
            _aPhysicalQuestions.Show();
        } 

        public void HidePhysicalQuestions() => _aPhysicalQuestions.Hide();

        public void OpenProfile(MaterialForm form)
        {
            _aProfile.Location = new Point(form.Location.X, form.Location.Y);
            _aProfile.Show();
        }

        public void HideProfile() => _aProfile.Hide();

        public void OpenProfile()
        {
            if (CurrentUser().IntPhysicalHealth)
            {
                _aProfile.Location = new Point(_aPhysicalQuestions.Location.X, _aPhysicalQuestions.Location.Y);
            }
            else
            {
                _aProfile.Location = new Point(_aMentalQuestions.Location.X, _aMentalQuestions.Location.Y);
            }
            _aProfile.Show();
        }

        public void OpenDialog(MaterialForm form)
        {
            _aDialog.Location = new Point(form.Location.X + form.Width / 4, form.Location.Y + form.Height / 4);
            if(form is Profile)
            {
                _aDialog.Delete = true;
            }
            _aDialog.Show();
        } 

        public void OpenModify(MaterialForm form)
        {
            _aModify.Location = new Point(form.Location.X + form.Width / 4, form.Location.Y + form.Height / 4);
            _aModify.Show();
        }

        public void UpdateBasicData(string firstName, string lastName, string email, string country, string password)
        {
            _aModel.CurrentUser.FirstName = firstName;
            _aModel.CurrentUser.LastName = lastName;
            _aModel.CurrentUser.Email = email;
            _aModel.CurrentUser.Country = country;
            _aModel.CurrentUser.Password = password;
        }

        public void UpdateInterests(bool mental, bool physique)
        {
            _aModel.CurrentUser.IntMentalHealth = mental;
            _aModel.CurrentUser.IntPhysicalHealth = physique;
        }

        public void UpdateMentalData(string state, bool friends, bool anxiety, string ease, string favourites1, string favourites2, string favourites3)
        {
            _aModel.CurrentUser.State = Byte.Parse(state);
            _aModel.CurrentUser.Friends = friends;
            _aModel.CurrentUser.Anxiety = anxiety;
            _aModel.CurrentUser.EaseToRelate = Byte.Parse(ease);
            _aModel.CurrentUser.Favourites1 = favourites1;
            _aModel.CurrentUser.Favourites2 = favourites2;
            _aModel.CurrentUser.Favourites3 = favourites3;
            _aModel.CurrentUser.MentalScore = MentalScore();
        }

        public void UpdatePhysicalData(bool sleep, bool exercises, bool water, string alimentation, bool medecines, string medecines1, string medecines2, string medecines3, int height, int weight)
        {
            _aModel.CurrentUser.Sleep = sleep;
            _aModel.CurrentUser.Exercises = exercises;
            _aModel.CurrentUser.Water = water;
            _aModel.CurrentUser.FoodQuality = Byte.Parse(alimentation);
            _aModel.CurrentUser.Medicines = medecines;
            _aModel.CurrentUser.Medicines1 = medecines1;
            _aModel.CurrentUser.Medicines2 = medecines2;
            _aModel.CurrentUser.Medicines3 = medecines3;
            _aModel.CurrentUser.Height = height;
            _aModel.CurrentUser.Weight = weight;
            _aModel.CurrentUser.PhysicalScore = PhysicalScore();
        }

        public void InsertData() => _aModel.InsertIntoDB();

        public void UpdateAllUsers() => _aModel.AllUsers = _aModel.ListUsers();

        public bool CheckUser(string email, string password)
        {
            foreach(User user in _aModel.AllUsers)
            {
                if(user.Email == email && user.Password == MasterPasswordVerification(password, email))
                {
                    _aModel.CurrentUser = user;
                    _aModel.CurrentUser.MentalScore = MentalScore();
                    _aModel.CurrentUser.PhysicalScore = PhysicalScore();
                    return true;
                }
            }
            return false;
        }

        public bool EmailExists(string email)
        {
            foreach(User u in _aModel.AllUsers)
            {
                if(u.Email == email && u != _aModel.CurrentUser)
                {
                    return true;
                }
            }
            return false;
        }

        public User CurrentUser()
        {
            return _aModel.CurrentUser;
        }

        private int MentalScore()
        {
            return (10 - _aModel.CurrentUser.State) + (_aModel.CurrentUser.Friends ? 0 : 10) + (_aModel.CurrentUser.Anxiety ? 10 : 0) + (10 - _aModel.CurrentUser.EaseToRelate) + ((_aModel.CurrentUser.Favourites1 == "") ? 3 : 0) + ((_aModel.CurrentUser.Favourites2 == "") ? 3 : 0) + ((_aModel.CurrentUser.Favourites3 == "") ? 2 : 0);
        }

        private int PhysicalScore()
        {
            return (_aModel.CurrentUser.Sleep ? 0 : 13) + (_aModel.CurrentUser.Exercises ? 0 : 12) + (_aModel.CurrentUser.Water ? 0 : 13) + (10 - _aModel.CurrentUser.FoodQuality);
        }

        public void Deconnection() => _aModel.CurrentUser = new User();

        public bool EmailCheck(string email)
        {
            return Regex.IsMatch(email, EMAIL_EX);
        }

        public bool NameCheck(string name)
        {
            return Regex.IsMatch(name, NAME_EX);
        }

        public bool PasswordCheck(string password)
        {
            return Regex.IsMatch(password, PASS_EX);
        }

        public bool RegCheck(bool firstName, bool lastName, bool email, bool password, bool repeat)
        {
            return firstName && lastName && email && password && repeat;
        }

        public bool RegCheck(bool firstName, bool lastName, bool email)
        {
            return firstName && lastName && email;
        }

        public bool WeightCheck(string weight)
        {
            return Regex.IsMatch(weight, WEIGHT_EX);
        }

        public string HashPassword(string clearPassword)
        {
            string salt = "";
            string hashPassword = "";
            int randomDigit;

            Random random = new Random();

            for (int i = 0; i < SALT_LENGTH; i++)
            {
                // Génère un chiffre entre 0 et 9
                randomDigit = random.Next(0, 10);
                salt += randomDigit.ToString();
            }

            clearPassword += salt;

            // Convertir le mot de passe clair en tableau de bytes
            byte[] passwordBytes = Encoding.UTF8.GetBytes(clearPassword);

            // Créer un objet de hachage SHA-256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Calcule le hachage du mot de passe
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                // Converti le tableau de bytes haché en une chaîne hexadécimale
                hashPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

            return hashPassword + salt;
        }

        private string MasterPasswordVerification(string userInput, string email)
        {
            User verifyUser = new User();
            foreach (User u in _aModel.AllUsers)
            {
                if (u.Email == email)
                {
                    verifyUser = u;
                }
            }
            string hashMasterPassword = verifyUser.Password;

            // Extrait le sel en clair
            string salt = hashMasterPassword.Substring(hashMasterPassword.Length - SALT_LENGTH);

            string hashPassword = "";

            userInput += salt;

            // Convertir le mot de passe clair en tableau de bytes
            byte[] passwordBytes = Encoding.UTF8.GetBytes(userInput);

            // Créer un objet de hachage SHA-256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Calcule le hachage du mot de passe
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                // Converti le tableau de bytes haché en une chaîne hexadécimale
                hashPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

            // Retourne le userInput hash avec le sel du MasterPassword + le sel en clair
            return hashPassword + salt;
        }

        public void UpdateUser()
        {
            _aModel.UpdateData();
        }

        public void LastUser()
        {
            User newUser = new User()
            {
                Id = 0
            };
            foreach(User u in _aModel.AllUsers)
            {
                if(u.Id > newUser.Id)
                {
                    newUser = u;
                }
            }
            _aModel.CurrentUser = newUser;
            _aModel.CurrentUser.MentalScore = MentalScore();
            _aModel.CurrentUser.PhysicalScore = PhysicalScore();
        }

        public void DeleteUser()
        {
            _aModel.DeleteUser();
            _aModel.AllUsers.Remove(_aModel.CurrentUser);
        }

        public void UpdatePassword(string password)
        {
            _aRegistration.TempPass = HashPassword(password);
        }

        public bool ModifyIsOpen()
        {
            return _aModify.Visible;
        }
    }
}
