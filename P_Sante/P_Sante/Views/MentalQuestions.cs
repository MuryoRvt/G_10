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

        public bool Modify { get; set; }

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
                    Controller.OpenPhysicalQuestions(this);
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

        private void MentalQuestions_VisibleChanged(object sender, EventArgs e)
        {
            if(Modify)
            {
                rdbYesFriends.Checked = Controller.CurrentUser().Friends;
                rdbNoFriends.Checked = !Controller.CurrentUser().Friends;
                rdbYesAnxiety.Checked = Controller.CurrentUser().Anxiety;
                rdbNoAnxiety.Checked = !Controller.CurrentUser().Anxiety;
                cmbZeroToTen1.SelectedIndex = Controller.CurrentUser().State;
                cmbZeroToTen2.SelectedIndex = Controller.CurrentUser().EaseToRelate;
                txtFavourites1.Text = Controller.CurrentUser().Favourites1;
                txtFavourites2.Text = Controller.CurrentUser().Favourites2;
                txtFavourites3.Text = Controller.CurrentUser().Favourites3;
                btnPrevious.Visible = false;
                btnNext.Text = "Finir";
                btnNext.Click -= btnNext_Click;
                btnNext.Click += Finish_Click;

                Modify = false;
            }
            else
            {
                rdbNoAnxiety.Checked = false;
                rdbNoFriends.Checked = false;
                rdbYesAnxiety.Checked = false;
                rdbYesFriends.Checked = false;
                cmbZeroToTen1.SelectedIndex = 0;
                cmbZeroToTen2.SelectedIndex = 0;
                txtFavourites1.Text = "";
                txtFavourites2.Text = "";
                txtFavourites3.Text = "";
                btnPrevious.Visible = true;
                btnNext.Text = "Suivant";
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            if ((rdbNoAnxiety.Checked || rdbYesAnxiety.Checked) && (rdbNoFriends.Checked || rdbYesFriends.Checked))
            {
                Controller.UpdateMentalData(cmbZeroToTen1.Text, rdbYesFriends.Checked, rdbYesAnxiety.Checked, cmbZeroToTen2.Text, txtFavourites1.Text, txtFavourites2.Text, txtFavourites3.Text);
                Controller.UpdateUser();

                Controller.OpenProfile(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les cases");
            }
            btnNext.Click += btnNext_Click;
            btnNext.Click -= Finish_Click;
        }
    }
}
