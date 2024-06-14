using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Sante.Views
{
    public partial class Interests : MaterialSkin.Controls.MaterialForm
    {

        public Controllers.Controller Controller { get; set; }

        public Interests()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(chkPhysHealth.Checked || chkMentalHealth.Checked)
            {
                Controller.UpdateInterests(chkMentalHealth.Checked, chkPhysHealth.Checked);
                if (Controller.CurrentUser().IntMentalHealth)
                    Controller.OpenMentalQuestions(this);
                else
                    Controller.OpenPhysicalQuestions(this);

                this.Hide();
            }
            else
            {
                MessageBox.Show("Choisissez qqch");
            }
        }

        private void Interests_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Interests_VisibleChanged(object sender, EventArgs e)
        {
            chkMentalHealth.Checked = false;
            chkPhysHealth.Checked = false;
        }

        private void chkMentalHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMentalHealth.Checked)
                picPinguin.Image = Properties.Resources.giphy_ezgif_com_webp_to_gif_converter;
            else
                picPinguin.Image = Properties.Resources.PinwinSad;
        }

        private void chkPhysHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhysHealth.Checked)
                picDuck.Image = Properties.Resources.duck_dancing_duck_unscreen;
            else
                picDuck.Image = Properties.Resources.DuckNotDancing;
        }

        private void picPinguin_Click(object sender, EventArgs e)
        {
            if (chkMentalHealth.Checked)
                chkMentalHealth.Checked = false;
            else
                chkMentalHealth.Checked = true;
        }

        private void picDuck_Click(object sender, EventArgs e)
        {
            if (chkPhysHealth.Checked)
                chkPhysHealth.Checked = false;
            else
                chkPhysHealth.Checked = true;
        }
    }
}
