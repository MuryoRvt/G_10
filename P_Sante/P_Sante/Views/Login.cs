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
using MaterialSkin.Controls;
using TextBoxForeColor;

namespace P_Sante.Views
{
    public partial class Login : MaterialForm
    {

        public Controller Controller { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Controller.OpenRegister();
            this.Hide();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            Controller.OpenInterests();
            this.Hide();
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            CustomMaterialTextBox txtSender = (CustomMaterialTextBox)sender;
            switch(txtSender)
            {
                case CustomMaterialTextBox txtbox when txtbox == txtEmail:
                    if (txtEmail.Text == "E-mail")
                    {
                        txtEmail.Text = "";
                        txtEmail.ForeColorCustom = Color.Black;
                    }
                    break;
                case CustomMaterialTextBox txtbox when txtbox == txtPassword:
                    if (txtPassword.Text == "Mot de passe")
                    {
                        txtPassword.Text = "";
                        txtPassword.ForeColorCustom = Color.Black;
                        txtPassword.IsPassword = true;
                    }
                    break;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            CustomMaterialTextBox txtSender = (CustomMaterialTextBox)sender;
            switch (txtSender)
            {
                case CustomMaterialTextBox txtbox when txtbox == txtEmail:
                    if (txtEmail.Text == "")
                    {
                        txtEmail.Text = "E-mail";
                        txtEmail.ForeColorCustom = Color.Gray;
                    }
                    break;
                case CustomMaterialTextBox txtbox when txtbox == txtPassword:
                    if (txtPassword.Text == "")
                    {
                        txtPassword.Text = "Mot de passe";
                        txtPassword.ForeColorCustom = Color.Gray;
                        txtPassword.IsPassword = false;
                    }
                    break;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmail.ForeColorCustom = Color.Gray;
            txtPassword.ForeColorCustom = Color.Gray;
        }
    }
}
