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

        /// <summary>
        /// Creates a new instance of Controller
        /// </summary>
        /// <param name="aLogin">Login page</param>
        /// <param name="aRegister">Register page</param>
        /// <param name="aModel">Model</param>
        public Controller(Login aLogin, Registration aRegister, Interests aInterests, MentalQuestions aMentalQuestions, PhysiqueQuestions aPhysiqueQuestions, Model aModel)
        {
            _aLogin = aLogin;
            _aRegister = aRegister;
            _aInterests = aInterests;
            _aMentalQuestions = aMentalQuestions;
            _aPhysiqueQuestions = aPhysiqueQuestions;
            _aModel = aModel;

            _aLogin.Controller = this;
            _aRegister.Controller = this;
            _aInterests.Controller = this;
            _aMentalQuestions.Controller = this;
            _aPhysiqueQuestions.Controller = this;
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
    }
}
