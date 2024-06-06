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
            Controller.OpenInterests();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Controller.OpenPhysiqueQuestions();
            this.Hide();
        }

        private void MentalQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
