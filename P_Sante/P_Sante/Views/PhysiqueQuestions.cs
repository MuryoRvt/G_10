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
    public partial class PhysiqueQuestions : MaterialSkin.Controls.MaterialForm
    {

        public Controllers.Controller Controller { get; set; }

        public PhysiqueQuestions()
        {
            InitializeComponent();
        }

        private void PhysiqueQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Controller.OpenMentalQuestions(this);
            this.Hide();
        }

        private void rdbYesMedecines_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbYesMedicines.Checked)
            {
                lblQP6.Visible = true;
                txtMedecines1.Visible = true;
                txtMedecines2.Visible = true;
                txtMedecines3.Visible = true;
            }
            else
            {
                lblQP6.Visible = false;
                txtMedecines1.Visible = false;
                txtMedecines2.Visible = false;
                txtMedecines3.Visible = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if((rdbNoExercises.Checked || rdbYesExercises.Checked) && (rdbNoSleep.Checked || rdbYesSleep.Checked) && (rdbNoWater.Checked || rdbYesWater.Checked) && (rdbNoMedecines.Checked || rdbYesMedicines.Checked))
            {
                if(Int32.TryParse(txtHeight.Text, out int result) && Controller.WeightCheck(txtWeight.Text))
                {
                    if(result > 50 && result < 300)
                    {
                        Controller.UpdatePhysicalData(rdbYesSleep.Checked, rdbYesExercises.Checked, rdbYesWater.Checked, cmbZeroToTen.Text, rdbYesMedicines.Checked, txtMedecines1.Text, txtMedecines2.Text, txtMedecines3.Text, result, Int32.Parse(txtWeight.Text));
                        Controller.OpenDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez donner la taille cohérente");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez donner le poids et la taille cohérents");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les cases");
            }
        }
    }
}
