using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Sante.Controllers;

namespace P_Sante.Views
{
    public partial class Register : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Controller to manage the views
        /// </summary>
        public Controller Controller { get; set; }

        public Register()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Controller.OpenLogin();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Controller.OpenLogin();
            this.Hide();
        }
    }
}
