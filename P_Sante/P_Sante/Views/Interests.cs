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
    public partial class Interests : Form
    {

        public Controller Controller { get; set; }

        public Interests()
        {
            InitializeComponent();
        }
    }
}
