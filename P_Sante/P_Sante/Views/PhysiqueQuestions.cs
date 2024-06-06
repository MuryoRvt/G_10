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
            Controller.OpenMentalQuestions();
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
            Controller.OpenProfile();
            this.Hide();
        }
    }
}
