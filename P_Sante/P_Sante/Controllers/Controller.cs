using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Sante.Views;
using P_Sante.Models;

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
        /// <summary>
        /// Model (db manager)
        /// </summary>
        private Model _aModel;

        private Interests _aInterests;

        private MentalQuestions _aMentalQuestions;

        private PhysiqueQuestions _aPhysiqueQuestions;

        private Profile _aProfile;

        /// <summary>
        /// Creates a new instance of Controller
        /// </summary>
        /// <param name="aLogin">Login page</param>
        /// <param name="aRegister">Register page</param>
        /// <param name="aModel">Model</param>
        public Controller(Login aLogin, Registration aRegister, Interests aInterests, MentalQuestions aMentalQuestions, PhysiqueQuestions aPhysiqueQuestions, Profile aProfile, Model aModel)
        {
            _aLogin = aLogin;
            _aRegister = aRegister;
            _aInterests = aInterests;
            _aMentalQuestions = aMentalQuestions;
            _aPhysiqueQuestions = aPhysiqueQuestions;
            _aProfile = aProfile;
            _aModel = aModel;

            _aLogin.Controller = this;
            _aRegister.Controller = this;
            _aInterests.Controller = this;
            _aMentalQuestions.Controller = this;
            _aPhysiqueQuestions.Controller = this;
            _aProfile.Controller = this;
            _aModel.Controller = this;
        }


        public void OpenRegister()
        {
            _aRegister.Show();
        }

        public void OpenLogin()
        {
            _aLogin.Show();
        }

        public void OpenInterests()
        {
            _aInterests.Show();
        }

        public void OpenMentalQuestions()
        {
            _aMentalQuestions.Show();
        }

        public void OpenPhysiqueQuestions()
        {
            _aPhysiqueQuestions.Show();
        }

        public void OpenProfile()
        {
            _aProfile.Show();
        }

        public void UpdateMentalData(string state, string friends, string anxiety, string facility, string favourites1, string favourites2, string favourites3)
        {
            _aModel.State = Int32.Parse(state);
            _aModel.Friends = (friends == "Non") ? 5 : 0;
            _aModel.Anxiety = (anxiety == "Oui") ? 10 : 0;
            _aModel.RelationshipFacility = Int32.Parse(facility);
            _aModel.Favourites.Clear();
            if(favourites1 != "")
            {
                _aModel.Favourites.Add(favourites1);
            }
            if (favourites2 != "")
            {
                _aModel.Favourites.Add(favourites2);
            }
            if (favourites3 != "")
            {
                _aModel.Favourites.Add(favourites3);
            }
            _aModel.MentalScore = Score();
        }

        public int Score()
        {
            return (10 - _aModel.State) + _aModel.Friends + _aModel.Anxiety + (10 - _aModel.RelationshipFacility) + ((_aModel.Favourites.Count == 0) ? 5 : 0);
        }

        public int MentalScore()
        {
            return _aModel.MentalScore * 15;
        }
    }
}
