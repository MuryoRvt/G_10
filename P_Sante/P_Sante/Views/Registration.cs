using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBoxForeColor;

namespace P_Sante.Views
{
    public partial class Registration : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Controller to manage the views
        /// </summary>
        public Controllers.Controller Controller { get; set; }

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
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mot de passe")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '•';
            }
        }
        private void txtRepeatPassword_Enter(object sender, EventArgs e)
        {
            if (txtRepeatPassword.Text == "Répétez le mdp")
            {
                txtRepeatPassword.Text = "";
                txtRepeatPassword.PasswordChar = '•';
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
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Mot de passe";
            }
        }
        private void txtRepeatPassword_Leave(object sender, EventArgs e)
        {
            if (txtRepeatPassword.Text == "")
            {
                txtRepeatPassword.PasswordChar = '\0';
                txtRepeatPassword.Text = "Répétez le mdp";
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            txtFirstName.ForeColorCustom = Color.Gray;
            txtLastName.ForeColorCustom = Color.Gray;
            txtEmail.ForeColorCustom = Color.Gray;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
