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
        private const int PNL_MULT = 5;

        private const int PNL_LOC = 3;

        public Controllers.Controller Controller { get; set; }

        private bool _open = true;

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_VisibleChanged(object sender, EventArgs e)
        {
            if (_open)
            {
                pnlMentalScore.Size = new Size(pnlMentalScore.Width, Controller.CurrentUser().MentalScore * PNL_MULT);
                pnlMentalScore.Location = new Point(pnlMentalScore.Location.X, picTermMentalCircle.Location.Y + PNL_LOC - pnlMentalScore.Height);
                pnlPhysScore.Size = new Size(pnlPhysScore.Width, Controller.CurrentUser().PhysicalScore * PNL_MULT);
                pnlPhysScore.Location = new Point(pnlPhysScore.Location.X, picTermPhysCircle.Location.Y + PNL_LOC - pnlPhysScore.Height);
                lblName.Text = $"{Controller.CurrentUser().FirstName} {Controller.CurrentUser().LastName}";
                _open = false;
            }
            else
            {
                _open = true;
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            pnlMentalScore.BackColor = ColorTranslator.FromHtml("#" + "D10F0F");
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDecon_Click(object sender, EventArgs e)
        {
            Controller.Deconnection();
            Controller.OpenLogin();
            this.Hide();
        }
    }
}
