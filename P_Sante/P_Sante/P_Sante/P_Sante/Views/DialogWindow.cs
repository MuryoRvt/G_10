﻿using System;
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
    public partial class DialogWindow : MaterialSkin.Controls.MaterialForm
    {

        public Controllers.Controller Controller { get; set; }

        public bool Delete { get; set; }

        public DialogWindow()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if(Delete)
            {
                Controller.DeleteUser();
                Controller.Deconnection();
                Delete = false;

                Controller.OpenLogin();
                Controller.HideProfile();
                this.Hide();
            }
            else
            {
                Controller.InsertData();
                Controller.UpdateAllUsers();
                Controller.LastUser();
                Controller.OpenProfile();
                this.Hide();
                if (Controller.CurrentUser().IntPhysicalHealth)
                {
                    Controller.HidePhysicalQuestions();
                }
                else
                {
                    Controller.HideMentalQuestions();
                }
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}