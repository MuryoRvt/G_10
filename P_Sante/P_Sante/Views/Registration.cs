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
using TextBoxForeColor;

namespace P_Sante.Views
{
    public partial class Registration : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Controller to manage the views
        /// </summary>
        public Controller Controller { get; set; }

        public Registration()
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

        private void txt_Enter(object sender, EventArgs e)
        {
            CustomMaterialTextBox txtSender = (CustomMaterialTextBox)sender;
            switch (txtSender)
            {
                case CustomMaterialTextBox txtbox1 when txtbox1 == txtFirstName:
                    if (txtFirstName.Text == "Prénom")
                    {
                        txtFirstName.Text = "";
                        txtFirstName.ForeColorCustom = Color.Black;
                    }
                    break;
                case CustomMaterialTextBox txtbox2 when txtbox2 == txtLastName:
                    if (txtLastName.Text == "Nom")
                    {
                        txtLastName.Text = "";
                        txtLastName.ForeColorCustom = Color.Black;
                    }
                    break;
                case CustomMaterialTextBox txtbox3 when txtbox3 == txtEmail:
                    if (txtEmail.Text == "E-mail")
                    {
                        txtEmail.Text = "";
                        txtEmail.ForeColorCustom = Color.Black;
                    }
                    break;
                case CustomMaterialTextBox txtbox4 when txtbox4 == txtPassword:
                    if (txtPassword.Text == "Mot de passe")
                    {
                        txtPassword.Text = "";
                        txtPassword.ForeColorCustom = Color.Black;
                        txtPassword.IsPassword = true;
                    }
                    break;
                case CustomMaterialTextBox txtbox5 when txtbox5 == txtRepeatPassword:
                    if (txtRepeatPassword.Text == "Répétez le mdp")
                    {
                        txtRepeatPassword.Text = "";
                        txtRepeatPassword.ForeColorCustom = Color.Black;
                        txtRepeatPassword.IsPassword = true;
                    }
                    break;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            CustomMaterialTextBox txtSender = (CustomMaterialTextBox)sender;
            switch (txtSender)
            {
                case CustomMaterialTextBox txtbox1 when txtbox1 == txtFirstName:
                    if (txtFirstName.Text == "")
                    {
                        txtFirstName.Text = "Prénom";
                        txtFirstName.ForeColorCustom = Color.Gray;
                    }
                    break;
                case CustomMaterialTextBox txtbox2 when txtbox2 == txtLastName:
                    if (txtLastName.Text == "")
                    {
                        txtLastName.Text = "Nom";
                        txtLastName.ForeColorCustom = Color.Gray;
                    }
                    break;
                case CustomMaterialTextBox txtbox3 when txtbox3 == txtEmail:
                    if (txtEmail.Text == "")
                    {
                        txtEmail.Text = "E-mail";
                        txtEmail.ForeColorCustom = Color.Gray;
                    }
                    break;
                case CustomMaterialTextBox txtbox4 when txtbox4 == txtPassword:
                    if (txtPassword.Text == "")
                    {
                        txtPassword.Text = "Mot de passe";
                        txtPassword.ForeColorCustom = Color.Gray;
                        txtPassword.IsPassword = false;
                    }
                    break;
                case CustomMaterialTextBox txtbox5 when txtbox5 == txtRepeatPassword:
                    if (txtRepeatPassword.Text == "")
                    {
                        txtRepeatPassword.Text = "Répétez le mdp";
                        txtRepeatPassword.ForeColorCustom = Color.Gray;
                        txtRepeatPassword.IsPassword = false;
                    }
                    break;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            txtFirstName.ForeColorCustom = Color.Gray;
            txtLastName.ForeColorCustom = Color.Gray;
            txtEmail.ForeColorCustom = Color.Gray;
            txtPassword.ForeColorCustom = Color.Gray;
            txtRepeatPassword.ForeColorCustom = Color.Gray;
        }
    }
}
