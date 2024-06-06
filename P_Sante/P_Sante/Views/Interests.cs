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
            Controller.OpenMentalQuestions();
            this.Hide();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Controller.OpenLogin();
            this.Hide();
        }

        private void Interests_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
