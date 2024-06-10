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
            if(chkActivities.Checked || chkAlimentation.Checked || chkMentalHealth.Checked || chkSleep.Checked)
            {
                Controller.UpdateInterests(chkMentalHealth.Checked, chkAlimentation.Checked, chkActivities.Checked, chkSleep.Checked);
                if (Controller.CurrentUser().IntMentalHealth)
                    Controller.OpenMentalQuestions();
                else
                    Controller.OpenPhysiqueQuestions();

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
    }
}
