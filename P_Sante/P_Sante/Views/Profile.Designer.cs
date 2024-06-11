namespace P_Sante.Views
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.btnDecon = new MaterialSkin.Controls.MaterialButton();
            this.lblPhysTemp = new MaterialSkin.Controls.MaterialLabel();
            this.lblTempMental = new MaterialSkin.Controls.MaterialLabel();
            this.pnlPhysScore2 = new System.Windows.Forms.Panel();
            this.pnlPhysScore1 = new System.Windows.Forms.Panel();
            this.pnlMentalScore1 = new System.Windows.Forms.Panel();
            this.pnlMentalScore2 = new System.Windows.Forms.Panel();
            this.btnContact = new MaterialSkin.Controls.MaterialButton();
            this.picTermPhysForm = new System.Windows.Forms.PictureBox();
            this.picTermMentalForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTermPhysForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(71, 114);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // btnDecon
            // 
            this.btnDecon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDecon.Depth = 0;
            this.btnDecon.HighEmphasis = true;
            this.btnDecon.Icon = null;
            this.btnDecon.Location = new System.Drawing.Point(74, 572);
            this.btnDecon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDecon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDecon.Name = "btnDecon";
            this.btnDecon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDecon.Size = new System.Drawing.Size(125, 36);
            this.btnDecon.TabIndex = 4;
            this.btnDecon.Text = "Déconnecter";
            this.btnDecon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDecon.UseAccentColor = false;
            this.btnDecon.UseVisualStyleBackColor = true;
            this.btnDecon.Click += new System.EventHandler(this.btnDecon_Click);
            // 
            // lblPhysTemp
            // 
            this.lblPhysTemp.AutoSize = true;
            this.lblPhysTemp.Depth = 0;
            this.lblPhysTemp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhysTemp.Location = new System.Drawing.Point(1016, 611);
            this.lblPhysTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhysTemp.Name = "lblPhysTemp";
            this.lblPhysTemp.Size = new System.Drawing.Size(66, 19);
            this.lblPhysTemp.TabIndex = 8;
            this.lblPhysTemp.Text = "Physique";
            // 
            // lblTempMental
            // 
            this.lblTempMental.AutoSize = true;
            this.lblTempMental.Depth = 0;
            this.lblTempMental.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTempMental.Location = new System.Drawing.Point(843, 611);
            this.lblTempMental.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTempMental.Name = "lblTempMental";
            this.lblTempMental.Size = new System.Drawing.Size(50, 19);
            this.lblTempMental.TabIndex = 9;
            this.lblTempMental.Text = "Mental";
            // 
            // pnlPhysScore2
            // 
            this.pnlPhysScore2.BackColor = System.Drawing.Color.IndianRed;
            this.pnlPhysScore2.Location = new System.Drawing.Point(1047, 423);
            this.pnlPhysScore2.Name = "pnlPhysScore2";
            this.pnlPhysScore2.Size = new System.Drawing.Size(24, 41);
            this.pnlPhysScore2.TabIndex = 1;
            // 
            // pnlPhysScore1
            // 
            this.pnlPhysScore1.BackColor = System.Drawing.Color.IndianRed;
            this.pnlPhysScore1.Location = new System.Drawing.Point(1035, 423);
            this.pnlPhysScore1.Name = "pnlPhysScore1";
            this.pnlPhysScore1.Size = new System.Drawing.Size(16, 41);
            this.pnlPhysScore1.TabIndex = 2;
            // 
            // pnlMentalScore1
            // 
            this.pnlMentalScore1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMentalScore1.Location = new System.Drawing.Point(852, 423);
            this.pnlMentalScore1.Name = "pnlMentalScore1";
            this.pnlMentalScore1.Size = new System.Drawing.Size(16, 41);
            this.pnlMentalScore1.TabIndex = 4;
            // 
            // pnlMentalScore2
            // 
            this.pnlMentalScore2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMentalScore2.Location = new System.Drawing.Point(864, 423);
            this.pnlMentalScore2.Name = "pnlMentalScore2";
            this.pnlMentalScore2.Size = new System.Drawing.Size(24, 41);
            this.pnlMentalScore2.TabIndex = 3;
            // 
            // btnContact
            // 
            this.btnContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContact.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnContact.Depth = 0;
            this.btnContact.HighEmphasis = true;
            this.btnContact.Icon = null;
            this.btnContact.Location = new System.Drawing.Point(422, 124);
            this.btnContact.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContact.Name = "btnContact";
            this.btnContact.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnContact.Size = new System.Drawing.Size(237, 36);
            this.btnContact.TabIndex = 11;
            this.btnContact.Text = "Contacter les spécialistes";
            this.btnContact.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnContact.UseAccentColor = false;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // picTermPhysForm
            // 
            this.picTermPhysForm.Image = global::P_Sante.Properties.Resources.Termo8Bits;
            this.picTermPhysForm.Location = new System.Drawing.Point(971, 197);
            this.picTermPhysForm.Name = "picTermPhysForm";
            this.picTermPhysForm.Size = new System.Drawing.Size(164, 411);
            this.picTermPhysForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermPhysForm.TabIndex = 10;
            this.picTermPhysForm.TabStop = false;
            // 
            // picTermMentalForm
            // 
            this.picTermMentalForm.BackColor = System.Drawing.Color.Transparent;
            this.picTermMentalForm.Image = global::P_Sante.Properties.Resources.Termo8BitsAzul;
            this.picTermMentalForm.Location = new System.Drawing.Point(788, 197);
            this.picTermMentalForm.Name = "picTermMentalForm";
            this.picTermMentalForm.Size = new System.Drawing.Size(164, 411);
            this.picTermMentalForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermMentalForm.TabIndex = 7;
            this.picTermMentalForm.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.pnlMentalScore1);
            this.Controls.Add(this.pnlMentalScore2);
            this.Controls.Add(this.pnlPhysScore1);
            this.Controls.Add(this.pnlPhysScore2);
            this.Controls.Add(this.picTermPhysForm);
            this.Controls.Add(this.lblTempMental);
            this.Controls.Add(this.lblPhysTemp);
            this.Controls.Add(this.picTermMentalForm);
            this.Controls.Add(this.btnDecon);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profile";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.VisibleChanged += new System.EventHandler(this.Profile_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picTermPhysForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialButton btnDecon;
        private System.Windows.Forms.PictureBox picTermMentalForm;
        private MaterialSkin.Controls.MaterialLabel lblPhysTemp;
        private MaterialSkin.Controls.MaterialLabel lblTempMental;
        private System.Windows.Forms.PictureBox picTermPhysForm;
        private System.Windows.Forms.Panel pnlPhysScore2;
        private System.Windows.Forms.Panel pnlPhysScore1;
        private System.Windows.Forms.Panel pnlMentalScore1;
        private System.Windows.Forms.Panel pnlMentalScore2;
        private MaterialSkin.Controls.MaterialButton btnContact;
    }
}