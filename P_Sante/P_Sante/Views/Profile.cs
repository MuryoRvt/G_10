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
    public partial class Profile : MaterialForm
    {

        public Controllers.Controller Controller { get; set; }

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_VisibleChanged(object sender, EventArgs e)
        {
            pnlMentalScore.Size = new Size(pnlMentalScore.Width, Controller.MentalScore());
            pnlMentalScore.Location = new Point(pnlMentalScore.Location.X, 588 - Controller.MentalScore());
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Controller.OpenPhysiqueQuestions();
            this.Hide();
        }
    }
}
