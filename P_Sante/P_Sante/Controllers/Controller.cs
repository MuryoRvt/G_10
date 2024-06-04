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
        private Register _aRegister;
        /// <summary>
        /// Model (db manager)
        /// </summary>
        private Model _aModel;

        private Interests _aInterests;

        /// <summary>
        /// Creates a new instance of Controller
        /// </summary>
        /// <param name="aLogin">Login page</param>
        /// <param name="aRegister">Register page</param>
        /// <param name="aModel">Model</param>
        public Controller(Login aLogin, Register aRegister, Interests aInterests, Model aModel)
        {
            _aLogin = aLogin;
            _aRegister = aRegister;
            _aInterests = aInterests;
            _aModel = aModel;

            _aLogin.Controller = this;
            _aRegister.Controller = this;
            _aInterests.Controller = this;
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
    }
}
