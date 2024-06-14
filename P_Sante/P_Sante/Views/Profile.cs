using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace P_Sante.Views
{
    public partial class Profile : MaterialForm
    {
        private const int PNL_MULT = 5;

        private const int PNL_LOC = 267;

        //private bool _open = true;

        private BackgroundWorker bgWorker;

        public Controllers.Controller Controller { get; set; }

        public Profile()
        {
            InitializeComponent();

            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += BgWorker_DoWork;
        }

        private void Profile_VisibleChanged(object sender, EventArgs e)
        {
            lblName.Text = Controller.CurrentUser().FirstName + " " + Controller.CurrentUser().LastName;
            lblEmail.Text = Controller.CurrentUser().Email;
            lblCountry.Text = Controller.CurrentUser().Country;
            //if (_open)
            //{
                foreach (Control c in this.Controls)
                {
                    c.Visible = true;
                }

                if (!Controller.CurrentUser().IntMentalHealth)
                {
                    pnlMentalScore1.Visible = false;
                    pnlMentalScore2.Visible = false;
                    picTermMentalForm.Visible = false;
                    lblTempMental.Visible = false;
                    btnChangeMentalAnswers.Visible = false;
                }
                if (!Controller.CurrentUser().IntPhysicalHealth)
                {
                    pnlPhysScore1.Visible = false;
                    pnlPhysScore2.Visible = false;
                    picTermPhysForm.Visible = false;
                    lblPhysTemp.Visible = false;
                    btnChangePhysAnswers.Visible = false;
                }
                switch (Controller.CurrentUser().Country)
                {
                    case "Suisse":
                        lblInfoPsy.Text = "Centre de Psychologie de Genève\n" +
                                          "15 Rue du Rhône, 1204 Genève, Suisse\n" +
                                          "+ 41 77 93 82 70\n\n" +
                                          "Clinique de Psychothérapie de Lausanne\n" +
                                          "22 Avenue de la Gare, 1003 Lausanne, Suisse\n" +
                                          "+ 41 77 84 90\n";
                        lblInfoPhys.Text = "Point d’eau\n" +
                                           "5 Spitalstrasse, 4056 Bâle, Suisse\n" +
                                           "+41 61 266 78 90\n\n" +
                                           "Clinique de Santé Physique de Zurich\n" +
                                           "10 Bahnhofstrasse, 8001 Zurich, Suisse\n" +
                                           "+41 44 225 33 44\n";
                        break;
                    case "France":
                        lblInfoPsy.Text = "Clinique de Psychologie et Bien-être\n" +
                                          "25 Rue des Érables, 75010 Paris, France\n" +
                                          "+33 1 42 36 78 90\n\n" +
                                          "Centre Psychologique de Lyon\n" +
                                          "47 Avenue des Acacias, 69003 Lyon, France\n" +
                                          "+33 4 78 56 24 32";
                        lblInfoPhys.Text = "Clinique Médicale de Nice\n" +
                                           "30 Avenue Jean Médecin, 06000 Nice, France\n" +
                                           "+33 4 93 88 77 66\n\n" +
                                           "Centre de Santé de Paris\n" +
                                           "18 Rue de Rivoli, 75004 Paris, France\n" +
                                           "+33 1 45 67 89 00";
                        break;
                }
               // _open = false;
            //}
            //else
            //{
               // _open = true;
            //}
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDecon_Click(object sender, EventArgs e)
        {
            Controller.Deconnection();
            Controller.OpenLogin(this);
            this.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            pnlPhysScore1.BackColor = ColorTranslator.FromHtml("#662A3C");
            pnlPhysScore2.BackColor = ColorTranslator.FromHtml("#9B3D4B");
            pnlMentalScore1.BackColor = ColorTranslator.FromHtml("#004871");
            pnlMentalScore2.BackColor = ColorTranslator.FromHtml("#0066ac");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Controller.OpenRegistration(this);
            this.Hide();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                pnlPhysScore1.Size = new Size(pnlPhysScore1.Width, 0);
                pnlPhysScore1.Location = new Point(pnlPhysScore1.Location.X, picTermPhysForm.Location.Y + PNL_LOC - pnlPhysScore1.Height);
                pnlPhysScore2.Size = new Size(pnlPhysScore2.Width, pnlPhysScore1.Height);
                pnlPhysScore2.Location = new Point(pnlPhysScore2.Location.X, picTermPhysForm.Location.Y + PNL_LOC - pnlPhysScore2.Height);
                pnlMentalScore1.Size = new Size(pnlMentalScore1.Width, 0);
                pnlMentalScore1.Location = new Point(pnlMentalScore1.Location.X, picTermMentalForm.Location.Y + PNL_LOC - pnlMentalScore1.Height);
                pnlMentalScore2.Size = new Size(pnlMentalScore2.Width, pnlMentalScore1.Height);
                pnlMentalScore2.Location = new Point(pnlMentalScore2.Location.X, picTermMentalForm.Location.Y + PNL_LOC - pnlMentalScore2.Height);

                if (!bgWorker.IsBusy)
                {
                    bgWorker.RunWorkerAsync();
                }
            }
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < Controller.CurrentUser().PhysicalScore * PNL_MULT; i += 4)
            {
                UpdatePanel(pnlPhysScore1, pnlPhysScore2, i, picTermPhysForm.Location.Y + PNL_LOC);
                Thread.Sleep(1);
            }
            for (int i = 0; i < Controller.CurrentUser().MentalScore * PNL_MULT; i += 4)
            {
                UpdatePanel(pnlMentalScore1, pnlMentalScore2, i, picTermMentalForm.Location.Y + PNL_LOC);
                Thread.Sleep(1);
            }
        }

        private void UpdatePanel(Panel panel1, Panel panel2, int height, int baseLocationY)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    panel1.Size = new Size(panel1.Width, height);
                    panel1.Location = new Point(panel1.Location.X, baseLocationY - panel1.Height);
                    panel2.Size = new Size(panel2.Width, panel1.Height);
                    panel2.Location = new Point(panel2.Location.X, baseLocationY - panel2.Height);
                }));
            }
            else
            {
                panel1.Size = new Size(panel1.Width, height);
                panel1.Location = new Point(panel1.Location.X, baseLocationY - panel1.Height);
                panel2.Size = new Size(panel2.Width, panel1.Height);
                panel2.Location = new Point(panel2.Location.X, baseLocationY - panel2.Height);
            }
        }

        private void btnChangePhysAnswers_Click(object sender, EventArgs e)
        {
            Controller.OpenPhysicalQuestions(this);
            this.Hide();
        }
    }
}
