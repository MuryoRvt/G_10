using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Sante.Controllers;

namespace P_Sante.Views
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {

        public Controller Controller { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Controller.OpenRegister();
            this.Hide();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            Controller.OpenInterests();
            this.Hide();
        }
    }
}
