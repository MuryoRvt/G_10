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
    public partial class State : MaterialForm
    {

        private const int PNL_MULT = 5;

        private const int PNL_LOC = 267;

        public Controllers.Controller Controller { get; set; }

        private bool _open = true;

        public State()
        {
            InitializeComponent();
        }

        private void State_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void State_VisibleChanged(object sender, EventArgs e)
        {
            if (_open)
            {
                foreach (Control c in this.Controls)
                {
                    c.Visible = true;
                }

                pnlPhysScore1.Size = new Size(pnlPhysScore1.Width, Controller.CurrentUser().PhysicalScore * PNL_MULT);
                pnlPhysScore1.Location = new Point(pnlPhysScore1.Location.X, picTermPhysForm.Location.Y + PNL_LOC - pnlPhysScore1.Height);
                pnlPhysScore2.Size = new Size(pnlPhysScore2.Width, pnlPhysScore1.Height);
                pnlPhysScore2.Location = new Point(pnlPhysScore2.Location.X, picTermPhysForm.Location.Y + PNL_LOC - pnlPhysScore2.Height);
                pnlMentalScore1.Size = new Size(pnlMentalScore1.Width, Controller.CurrentUser().MentalScore * PNL_MULT);
                pnlMentalScore1.Location = new Point(pnlMentalScore1.Location.X, picTermMentalForm.Location.Y + PNL_LOC - pnlMentalScore1.Height);
                pnlMentalScore2.Size = new Size(pnlMentalScore2.Width, pnlMentalScore1.Height);
                pnlMentalScore2.Location = new Point(pnlMentalScore2.Location.X, picTermMentalForm.Location.Y + PNL_LOC - pnlMentalScore2.Height);
                

                if (!Controller.CurrentUser().IntMentalHealth)
                {
                    pnlMentalScore1.Visible = false;
                    pnlMentalScore2.Visible = false;
                    picTermMentalForm.Visible = false;
                    lblTempMental.Visible = false;
                }
                if (!Controller.CurrentUser().IntPhysicalHealth)
                {
                    pnlPhysScore1.Visible = false;
                    pnlPhysScore2.Visible = false;
                    picTermPhysForm.Visible = false;
                    lblPhysTemp.Visible = false;
                }
                _open = false;
            }
            else
            {
                _open = true;
            }
        }

        private void State_Load(object sender, EventArgs e)
        {
            pnlPhysScore1.BackColor = ColorTranslator.FromHtml("#662A3C");
            pnlPhysScore2.BackColor = ColorTranslator.FromHtml("#9B3D4B");
            pnlMentalScore1.BackColor = ColorTranslator.FromHtml("#004871");
            pnlMentalScore2.BackColor = ColorTranslator.FromHtml("#0066ac");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Controller.OpenProfile(this);
            this.Hide();
        }
    }
}
