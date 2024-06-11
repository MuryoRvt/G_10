﻿using System;
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
        private Registration _aRegister;

        private Interests _aInterests;

        private MentalQuestions _aMentalQuestions;

        private PhysiqueQuestions _aPhysiqueQuestions;

        private Profile _aProfile;

        private DialogWindow _aDialog;

        private Contact _aContact;
        /// <summary>
        /// Model (db manager)
        /// </summary>
        private Model _aModel;

        private string _nameEx = @"^[A-Za-zÀ-ÖØ-öø-ÿ\- ']+$";

        private string _emailEx = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        private string _passEx = @"^(?=.*\d)(?=.*[^a-zA-Z0-9,]).{12,}$";

        private string _weightEx = @"^\d{1,3}$";

        private const int SALT_LENGTH = 40;

        /// <summary>
        /// Creates a new instance of Controller
        /// </summary>
        /// <param name="aLogin">Login page</param>
        /// <param name="aRegister">Register page</param>
        /// <param name="aModel">Model</param>
        public Controller(Login aLogin, Registration aRegister, Interests aInterests, MentalQuestions aMentalQuestions, PhysiqueQuestions aPhysiqueQuestions, Profile aProfile, DialogWindow aDialog, Contact aContact, Model aModel)
        {
            _aLogin = aLogin;
            _aRegister = aRegister;
            _aInterests = aInterests;
            _aMentalQuestions = aMentalQuestions;
            _aPhysiqueQuestions = aPhysiqueQuestions;
            _aProfile = aProfile;
            _aDialog = aDialog;
            _aContact = aContact;
            _aModel = aModel;

            _aLogin.Controller = this;
            _aRegister.Controller = this;
            _aInterests.Controller = this;
            _aMentalQuestions.Controller = this;
            _aPhysiqueQuestions.Controller = this;
            _aProfile.Controller = this;
            _aDialog.Controller = this;
            _aContact.Controller = this;
            _aModel.Controller = this;
        }

        public void OpenRegister(MaterialForm form)
        {
            _aRegister.Location = new Point(form.Location.X, form.Location.Y);
            _aRegister.Show();
        }

        public void OpenLogin(MaterialForm form) 
        {
            _aLogin.StartPosition = FormStartPosition.Manual;
            _aLogin.Location = new Point(form.Location.X, form.Location.Y);
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
            _aMentalQuestions.Show();
        } 

        public void OpenPhysiqueQuestions(MaterialForm form)
        {
            _aPhysiqueQuestions.Location = new Point(form.Location.X, form.Location.Y);
            _aPhysiqueQuestions.Show();
        } 

        public void HidePhysiqueQuestions() => _aPhysiqueQuestions.Hide();

        public void OpenProfile(MaterialForm form)
        {
            _aProfile.Location = new Point(form.Location.X, form.Location.Y);
            _aProfile.Show();
        }

        public void OpenProfile()
        {
            if (CurrentUser().IntPhysicalHealth)
            {
                _aProfile.Location = new Point(_aPhysiqueQuestions.Location.X, _aPhysiqueQuestions.Location.Y);
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
            _aDialog.Show();
        } 

        public void OpenContact(MaterialForm form)
        {
            _aContact.Location = new Point(form.Location.X, form.Location.Y);
            _aContact.Show();
        }

        public void UpdateBasicData(string firstName, string lastName, string email, string country, string password)
        {
            _aModel.CurrentUser.FirstName = firstName;
            _aModel.CurrentUser.LastName = lastName;
            _aModel.CurrentUser.Email = email;
            _aModel.CurrentUser.Country = country;
            _aModel.CurrentUser.Password = HashPassword(password);
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
            _aModel.CurrentUser.PhysicalScore = PhysicalScore();
        }

        public void InsertData() => _aModel.InsertIntoDB(_aModel.CurrentUser);

        public void UpdateUsers() => _aModel.AllUsers = _aModel.ListUsers();

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
            return Regex.IsMatch(email, _emailEx);
        }

        public bool NameCheck(string name)
        {
            return Regex.IsMatch(name, _nameEx);
        }

        public bool PasswordCheck(string password)
        {
            return Regex.IsMatch(password, _passEx);
        }

        public bool RegCheck(bool firstName, bool lastName, bool email, bool password, bool repeat)
        {
            return firstName && lastName && email && password && repeat;
        }

        public bool WeightCheck(string weight)
        {
            return Regex.IsMatch(weight, _weightEx);
        }

        public void AddUser() => _aModel.AllUsers.Add(_aModel.CurrentUser);

        private static string HashPassword(string clearPassword)
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
    }
}
