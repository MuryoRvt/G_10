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
    public partial class ModifyPassword : MaterialForm
    {
        private Image _check = Properties.Resources.check;

        private Image _nonCheck = Properties.Resources.multiply;

        public Controllers.Controller Controller { get; set; }

        public ModifyPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                picPassword.Visible = true;
            }
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
            if (txtRepeatPassword.PasswordChar == '\0')
            {
                picRepeatPassword.Visible = true;
            }
            if (Controller.PasswordCheck(txtRepeatPassword.Text) && txtRepeatPassword.Text == txtPassword.Text)
            {
                picRepeatPassword.Image = _check;
            }
            else
            {
                picRepeatPassword.Image = _nonCheck;
            }
        }

        private void btnFinishPass_Click(object sender, EventArgs e)
        {
            if(picPassword.Image == _check && picRepeatPassword.Image == _check)
            {
                Controller.UpdatePassword(txtPassword.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("NON");
            }
        }
    }
}
