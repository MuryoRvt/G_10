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
        private Image _eye = Properties.Resources.eye;

        private Image _noEye = Properties.Resources.noeye;
        /// <summary>
        /// Controller to manage the views
        /// </summary>
        public Controllers.Controller Controller { get; set; }

        private Image _check = Properties.Resources.check;

        private Image _nonCheck = Properties.Resources.multiply;

        public bool Modify { get; set; } = false;

        public string TempPass { get; set; } = "";

        public Registration()
        {
            InitializeComponent();

            picEyePass.Image = _noEye;
            picEyeRep.Image = _noEye;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Controller.OpenLogin(this);
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(Controller.RegCheck(picFirstName.Image == _check, picLastName.Image == _check, picEmail.Image == _check, picPassword.Image == _check, picRepeatPassword.Image == _check))
            {
                if(Controller.EmailExists(txtEmail.Text))
                {
                    MessageBox.Show("L'utilisateur avec cet email existe déjà");
                }
                else
                {
                    Controller.UpdateBasicData(txtFirstName.Text, txtLastName.Text, txtEmail.Text, comboCountry.Text, Controller.HashPassword(txtPassword.Text));
                    Controller.OpenInterests(this);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("NON");
            }
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
                if (picEyePass.Image == _noEye)
                    txtPassword.PasswordChar = '•';

                txtPassword.Text = "";
                picPassword.Visible = true;
            }
        }
        private void txtRepeatPassword_Enter(object sender, EventArgs e)
        {
            if (txtRepeatPassword.Text == "Répétez le mdp")
            {
                if (picEyeRep.Image == _noEye)
                    txtRepeatPassword.PasswordChar = '•';

                txtRepeatPassword.Text = "";
                picRepeatPassword.Visible = true;
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
                        txtFirstName.ForeColorCustom = Color.Gray;
                        txtFirstName.Text = "Prénom";
                        picFirstName.Image = _nonCheck;
                        picFirstName.Visible = false;
                    }
                    break;
                case CustomMaterialTextBox txtbox2 when txtbox2 == txtLastName:
                    if (txtLastName.Text == "")
                    {
                        txtLastName.ForeColorCustom = Color.Gray;
                        txtLastName.Text = "Nom";
                        picLastName.Image = _nonCheck;
                        picLastName.Visible = false;
                    }
                    break;
                case CustomMaterialTextBox txtbox3 when txtbox3 == txtEmail:
                    if (txtEmail.Text == "")
                    {
                        txtEmail.ForeColorCustom = Color.Gray;
                        txtEmail.Text = "E-mail";
                        picEmail.Image = _nonCheck;
                        picEmail.Visible = false;
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
                picPassword.Image = _nonCheck;
                picPassword.Visible = false;
            }
        }
        private void txtRepeatPassword_Leave(object sender, EventArgs e)
        {
            if (txtRepeatPassword.Text == "")
            {
                txtRepeatPassword.PasswordChar = '\0';
                txtRepeatPassword.Text = "Répétez le mdp";
                picRepeatPassword.Image = _nonCheck;
                picRepeatPassword.Visible = false;
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

        private void Registration_VisibleChanged(object sender, EventArgs e)
        {
            if(Modify)
            {
                txtFirstName.Text = Controller.CurrentUser().FirstName;
                txtFirstName.ForeColorCustom = Color.Black;
                txtLastName.Text = Controller.CurrentUser().LastName;
                txtLastName.ForeColorCustom = Color.Black;
                txtEmail.Text = Controller.CurrentUser().Email;
                txtEmail.ForeColorCustom = Color.Black;
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Mot de passe";
                txtRepeatPassword.PasswordChar = '\0';
                txtRepeatPassword.Text = "Répétez le mdp";
                picFirstName.Visible = true;
                picLastName.Visible = true;
                picEmail.Visible = true;
                picPassword.Visible = false;
                picRepeatPassword.Visible = false;
                txtPassword.Visible = false;
                picEyePass.Visible = false;
                txtRepeatPassword.Visible = false;
                picEyeRep.Visible = false;
                lblPassInfo.Visible = false;
                btnSignIn.Visible = false;
                btnSignUp.Visible = false;
                lblDialog_Guide.Text = "Modification";

                btnModifyPassword.Visible = true;
                btnFinishModification.Visible = true;

                TempPass = Controller.CurrentUser().Password;

                Modify = false;
            }
            else
            {
                txtFirstName.Text = "Prénom";
                txtFirstName.ForeColorCustom = Color.Gray;
                txtLastName.Text = "Nom";
                txtLastName.ForeColorCustom = Color.Gray;
                txtEmail.Text = "E-mail";
                txtEmail.ForeColorCustom = Color.Gray;
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Mot de passe";
                txtRepeatPassword.PasswordChar = '\0';
                txtRepeatPassword.Text = "Répétez le mdp";
                picFirstName.Visible = false;
                picLastName.Visible = false;
                picEmail.Visible = false;
                picPassword.Visible = false;
                picRepeatPassword.Visible = false;
                txtPassword.Visible = true;
                picEyePass.Visible = true;
                txtRepeatPassword.Visible = true;
                picEyeRep.Visible = true;
                lblPassInfo.Visible = true;
                btnSignIn.Visible = true;
                btnSignUp.Visible = true;
                lblDialog_Guide.Text = "Registration";

                btnModifyPassword.Visible = false;
                btnFinishModification.Visible = false;
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            CustomMaterialTextBox txtSender = (CustomMaterialTextBox)sender;
            switch (txtSender)
            {
                case CustomMaterialTextBox txtbox1 when txtbox1 == txtFirstName:
                    if (txtFirstName.ForeColorCustom != Color.Gray)
                    {
                        picFirstName.Visible = true;
                    }
                    if (Controller.NameCheck(txtFirstName.Text))
                    {
                        picFirstName.Image = _check;
                    }
                    else
                    {
                        picFirstName.Image = _nonCheck;
                    }
                    break;
                case CustomMaterialTextBox txtbox2 when txtbox2 == txtLastName:
                    if (txtLastName.ForeColorCustom != Color.Gray)
                    {
                        picLastName.Visible = true;
                    }
                    if (Controller.NameCheck(txtLastName.Text))
                    {
                        picLastName.Image = _check;
                    }
                    else
                    {
                        picLastName.Image = _nonCheck;
                    }
                    break;
                case CustomMaterialTextBox txtbox3 when txtbox3 == txtEmail:
                    if(txtEmail.ForeColorCustom != Color.Gray)
                    {
                        picEmail.Visible = true;
                    }
                    if (Controller.EmailCheck(txtEmail.Text))
                    {
                        picEmail.Image = _check;
                    }
                    else
                    {
                        picEmail.Image = _nonCheck;
                    }
                    break;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (Controller.PasswordCheck(txtPassword.Text))
            {
                picPassword.Image = _check;
            }
            else
            {
                picPassword.Image = _nonCheck;
            }
        }

        private void txtRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            if (Controller.PasswordCheck(txtRepeatPassword.Text) && txtRepeatPassword.Text == txtPassword.Text)
            {
                picRepeatPassword.Image = _check;
            }
            else
            {
                picRepeatPassword.Image = _nonCheck;
            }
        }

        private void btnFinishModification_Click(object sender, EventArgs e)
        {
            if(!Controller.ModifyIsOpen())
            {
                if (Controller.RegCheck(picFirstName.Image == _check, picLastName.Image == _check, picEmail.Image == _check))
                {
                    if (Controller.EmailExists(txtEmail.Text))
                    {
                        MessageBox.Show("L'utilisateur avec cet email existe déjà");
                    }
                    else
                    {
                        Controller.UpdateBasicData(txtFirstName.Text, txtLastName.Text, txtEmail.Text, comboCountry.Text, TempPass);
                        Controller.UpdateUser();

                        TempPass = "";

                        Controller.OpenProfile(this);
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("NON");
                }
            }
        }

        private void btnModifyPassword_Click(object sender, EventArgs e)
        {
            Controller.OpenModify(this);
        }

        private void picEyePass_Click(object sender, EventArgs e)
        {
            if (picEyePass.Image == _noEye && txtPassword.Text != "Mot de passe")
            {
                picEyePass.Image = _eye;
                txtPassword.PasswordChar = '\0';
            }
            else if (picEyePass.Image == _eye && txtPassword.Text != "Mot de passe")
            {
                picEyePass.Image = _noEye;
                txtPassword.PasswordChar = '•';
            }
        }

        private void picEyeRep_Click(object sender, EventArgs e)
        {
            if (picEyeRep.Image == _noEye && txtRepeatPassword.Text != "Répétez le mdp")
            {
                picEyeRep.Image = _eye;
                txtRepeatPassword.PasswordChar = '\0';
            }
            else if (picEyeRep.Image == _eye && txtRepeatPassword.Text != "Répétez le mdp")
            {
                picEyeRep.Image = _noEye;
                txtRepeatPassword.PasswordChar = '•';
            }
        }
    }
}
