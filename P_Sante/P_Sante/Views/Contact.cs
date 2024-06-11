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
    public partial class Contact : MaterialForm
    {

        public Controllers.Controller Controller { get; set; }

        public Contact()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Controller.OpenProfile(this);
            this.Hide();
        }

        private void Contact_VisibleChanged(object sender, EventArgs e)
        {
            switch(Controller.CurrentUser().Country)
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
        }

        private void Contact_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
