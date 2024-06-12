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
    public partial class MentalQuestions : MaterialSkin.Controls.MaterialForm
    {

        public Controllers.Controller Controller { get; set; }

        public MentalQuestions()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Controller.OpenInterests(this);
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if((rdbNoAnxiety.Checked || rdbYesAnxiety.Checked) && (rdbNoFriends.Checked || rdbYesFriends.Checked))
            {
                Controller.UpdateMentalData(cmbZeroToTen1.Text, rdbYesFriends.Checked, rdbYesAnxiety.Checked, cmbZeroToTen2.Text, txtFavourites1.Text, txtFavourites2.Text, txtFavourites3.Text);
                if (Controller.CurrentUser().IntPhysicalHealth)
                {
                    Controller.OpenPhysiqueQuestions(this);
                }
                else
                {
                    Controller.OpenDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les cases");
            }
        }

        private void MentalQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
