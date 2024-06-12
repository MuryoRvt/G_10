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
            lblName.Text = Controller.CurrentUser().FirstName + " " + Controller.CurrentUser().LastName;
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

        private void btnContact_Click(object sender, EventArgs e)
        {
            Controller.OpenContact(this);
            this.Hide();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            Controller.OpenState(this);
            this.Hide();
        }
    }
}
