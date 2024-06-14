using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace P_Sante.Views
{
    public partial class Login : MaterialForm
    {
        private Image _eye = Properties.Resources.eye;

        private Image _noEye = Properties.Resources.noeye;

        public Controllers.Controller Controller { get; set; }

        public Login()
        {
            InitializeComponent();

            picEye.Image = _noEye;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Controller.OpenRegistration(this);
            this.Hide();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            Controller.OpenInterests(this);
            this.Hide();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-mail")
            {
                txtEmail.Text = "";
                txtEmail.ForeColorCustom = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mot de passe")
            {
                if (picEye.Image == _noEye)
                    txtPassword.PasswordChar = '•';

                txtPassword.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-mail";
                txtEmail.ForeColorCustom = Color.Gray;
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

        private void Login_Load(object sender, EventArgs e)
        {
            Controller.UpdateAllUsers();
            txtEmail.ForeColorCustom = Color.Gray;
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green400, MaterialSkin.Primary.Green500, MaterialSkin.Primary.Brown50, MaterialSkin.Accent.DeepOrange700, MaterialSkin.TextShade.WHITE);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(Controller.CheckUser(txtEmail.Text, txtPassword.Text))
            {
                Controller.OpenProfile(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou mdp ne sont pas justes");
            }
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            txtEmail.Text = "E-mail";
            txtEmail.ForeColorCustom = Color.Gray;
            txtPassword.PasswordChar = '\0';
            txtPassword.Text = "Mot de passe";
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            if(picEye.Image == _noEye && txtPassword.Text != "Mot de passe")
            {
                picEye.Image = _eye;
                txtPassword.PasswordChar = '\0';
            }
            else if(picEye.Image == _eye && txtPassword.Text != "Mot de passe")
            {
                picEye.Image = _noEye;
                txtPassword.PasswordChar = '•';
            }
        }
    }
}
