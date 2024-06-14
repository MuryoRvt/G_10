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
            this.btnDecon = new MaterialSkin.Controls.MaterialButton();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnModify = new MaterialSkin.Controls.MaterialButton();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChangePhysAnswers = new MaterialSkin.Controls.MaterialButton();
            this.btnChangeMentalAnswers = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMentalScore1 = new System.Windows.Forms.Panel();
            this.pnlMentalScore2 = new System.Windows.Forms.Panel();
            this.pnlPhysScore1 = new System.Windows.Forms.Panel();
            this.pnlPhysScore2 = new System.Windows.Forms.Panel();
            this.picTermPhysForm = new System.Windows.Forms.PictureBox();
            this.lblTempMental = new MaterialSkin.Controls.MaterialLabel();
            this.lblPhysTemp = new MaterialSkin.Controls.MaterialLabel();
            this.picTermMentalForm = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblInfoPhys = new System.Windows.Forms.Label();
            this.lblInfoPsy = new System.Windows.Forms.Label();
            this.lblPhys = new System.Windows.Forms.Label();
            this.lblPsy = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnDeleteAccount = new MaterialSkin.Controls.MaterialButton();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermPhysForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalForm)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDecon
            // 
            this.btnDecon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDecon.Depth = 0;
            this.btnDecon.HighEmphasis = true;
            this.btnDecon.Icon = null;
            this.btnDecon.Location = new System.Drawing.Point(24, 486);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Depth = 0;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl.Location = new System.Drawing.Point(6, 74);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1147, 576);
            this.tabControl.TabIndex = 13;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteAccount);
            this.tabPage1.Controls.Add(this.btnModify);
            this.tabPage1.Controls.Add(this.lblCountry);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.btnDecon);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1139, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mes infos";
            // 
            // btnModify
            // 
            this.btnModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModify.Depth = 0;
            this.btnModify.HighEmphasis = true;
            this.btnModify.Icon = null;
            this.btnModify.Location = new System.Drawing.Point(413, 130);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModify.Name = "btnModify";
            this.btnModify.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModify.Size = new System.Drawing.Size(88, 36);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Modifier";
            this.btnModify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModify.UseAccentColor = false;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCountry.Location = new System.Drawing.Point(40, 142);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(50, 24);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Pays";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEmail.Location = new System.Drawing.Point(40, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblName.Location = new System.Drawing.Point(39, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 29);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nom";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChangePhysAnswers);
            this.tabPage2.Controls.Add(this.btnChangeMentalAnswers);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.pnlMentalScore1);
            this.tabPage2.Controls.Add(this.pnlMentalScore2);
            this.tabPage2.Controls.Add(this.pnlPhysScore1);
            this.tabPage2.Controls.Add(this.pnlPhysScore2);
            this.tabPage2.Controls.Add(this.picTermPhysForm);
            this.tabPage2.Controls.Add(this.lblTempMental);
            this.tabPage2.Controls.Add(this.lblPhysTemp);
            this.tabPage2.Controls.Add(this.picTermMentalForm);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1139, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mon état";
            // 
            // btnChangePhysAnswers
            // 
            this.btnChangePhysAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangePhysAnswers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangePhysAnswers.Depth = 0;
            this.btnChangePhysAnswers.HighEmphasis = true;
            this.btnChangePhysAnswers.Icon = null;
            this.btnChangePhysAnswers.Location = new System.Drawing.Point(903, 438);
            this.btnChangePhysAnswers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangePhysAnswers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangePhysAnswers.Name = "btnChangePhysAnswers";
            this.btnChangePhysAnswers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangePhysAnswers.Size = new System.Drawing.Size(196, 36);
            this.btnChangePhysAnswers.TabIndex = 38;
            this.btnChangePhysAnswers.Text = "Changer les réponses";
            this.btnChangePhysAnswers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangePhysAnswers.UseAccentColor = false;
            this.btnChangePhysAnswers.UseVisualStyleBackColor = true;
            this.btnChangePhysAnswers.Click += new System.EventHandler(this.btnChangePhysAnswers_Click);
            // 
            // btnChangeMentalAnswers
            // 
            this.btnChangeMentalAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeMentalAnswers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangeMentalAnswers.Depth = 0;
            this.btnChangeMentalAnswers.HighEmphasis = true;
            this.btnChangeMentalAnswers.Icon = null;
            this.btnChangeMentalAnswers.Location = new System.Drawing.Point(45, 438);
            this.btnChangeMentalAnswers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangeMentalAnswers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeMentalAnswers.Name = "btnChangeMentalAnswers";
            this.btnChangeMentalAnswers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangeMentalAnswers.Size = new System.Drawing.Size(196, 36);
            this.btnChangeMentalAnswers.TabIndex = 37;
            this.btnChangeMentalAnswers.Text = "Changer les réponses";
            this.btnChangeMentalAnswers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangeMentalAnswers.UseAccentColor = false;
            this.btnChangeMentalAnswers.UseVisualStyleBackColor = true;
            this.btnChangeMentalAnswers.Click += new System.EventHandler(this.btnChangeMentalAnswers_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::P_Sante.Properties.Resources.HappyFace8Bits;
            this.pictureBox2.Location = new System.Drawing.Point(542, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P_Sante.Properties.Resources.sadface8Bit;
            this.pictureBox1.Location = new System.Drawing.Point(542, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMentalScore1
            // 
            this.pnlMentalScore1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMentalScore1.Location = new System.Drawing.Point(464, 289);
            this.pnlMentalScore1.Name = "pnlMentalScore1";
            this.pnlMentalScore1.Size = new System.Drawing.Size(16, 41);
            this.pnlMentalScore1.TabIndex = 30;
            // 
            // pnlMentalScore2
            // 
            this.pnlMentalScore2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMentalScore2.Location = new System.Drawing.Point(476, 289);
            this.pnlMentalScore2.Name = "pnlMentalScore2";
            this.pnlMentalScore2.Size = new System.Drawing.Size(24, 41);
            this.pnlMentalScore2.TabIndex = 29;
            // 
            // pnlPhysScore1
            // 
            this.pnlPhysScore1.BackColor = System.Drawing.Color.IndianRed;
            this.pnlPhysScore1.Location = new System.Drawing.Point(669, 289);
            this.pnlPhysScore1.Name = "pnlPhysScore1";
            this.pnlPhysScore1.Size = new System.Drawing.Size(16, 41);
            this.pnlPhysScore1.TabIndex = 28;
            // 
            // pnlPhysScore2
            // 
            this.pnlPhysScore2.BackColor = System.Drawing.Color.IndianRed;
            this.pnlPhysScore2.Location = new System.Drawing.Point(681, 289);
            this.pnlPhysScore2.Name = "pnlPhysScore2";
            this.pnlPhysScore2.Size = new System.Drawing.Size(24, 41);
            this.pnlPhysScore2.TabIndex = 27;
            // 
            // picTermPhysForm
            // 
            this.picTermPhysForm.Image = global::P_Sante.Properties.Resources.Termo8Bits;
            this.picTermPhysForm.Location = new System.Drawing.Point(605, 63);
            this.picTermPhysForm.Name = "picTermPhysForm";
            this.picTermPhysForm.Size = new System.Drawing.Size(164, 411);
            this.picTermPhysForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermPhysForm.TabIndex = 34;
            this.picTermPhysForm.TabStop = false;
            // 
            // lblTempMental
            // 
            this.lblTempMental.AutoSize = true;
            this.lblTempMental.Depth = 0;
            this.lblTempMental.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTempMental.Location = new System.Drawing.Point(437, 477);
            this.lblTempMental.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTempMental.Name = "lblTempMental";
            this.lblTempMental.Size = new System.Drawing.Size(95, 19);
            this.lblTempMental.TabIndex = 33;
            this.lblTempMental.Text = "Santé Mental";
            // 
            // lblPhysTemp
            // 
            this.lblPhysTemp.AutoSize = true;
            this.lblPhysTemp.Depth = 0;
            this.lblPhysTemp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhysTemp.Location = new System.Drawing.Point(628, 477);
            this.lblPhysTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhysTemp.Name = "lblPhysTemp";
            this.lblPhysTemp.Size = new System.Drawing.Size(111, 19);
            this.lblPhysTemp.TabIndex = 32;
            this.lblPhysTemp.Text = "Santé Physique";
            // 
            // picTermMentalForm
            // 
            this.picTermMentalForm.BackColor = System.Drawing.Color.Transparent;
            this.picTermMentalForm.Image = global::P_Sante.Properties.Resources.Termo8BitsAzul;
            this.picTermMentalForm.Location = new System.Drawing.Point(400, 63);
            this.picTermMentalForm.Name = "picTermMentalForm";
            this.picTermMentalForm.Size = new System.Drawing.Size(164, 411);
            this.picTermMentalForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermMentalForm.TabIndex = 31;
            this.picTermMentalForm.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblInfoPhys);
            this.tabPage3.Controls.Add(this.lblInfoPsy);
            this.tabPage3.Controls.Add(this.lblPhys);
            this.tabPage3.Controls.Add(this.lblPsy);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1139, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Spécialistes";
            // 
            // lblInfoPhys
            // 
            this.lblInfoPhys.AutoSize = true;
            this.lblInfoPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInfoPhys.Location = new System.Drawing.Point(65, 309);
            this.lblInfoPhys.Name = "lblInfoPhys";
            this.lblInfoPhys.Size = new System.Drawing.Size(74, 20);
            this.lblInfoPhys.TabIndex = 15;
            this.lblInfoPhys.Text = "Info phys";
            // 
            // lblInfoPsy
            // 
            this.lblInfoPsy.AutoSize = true;
            this.lblInfoPsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInfoPsy.Location = new System.Drawing.Point(65, 111);
            this.lblInfoPsy.Name = "lblInfoPsy";
            this.lblInfoPsy.Size = new System.Drawing.Size(65, 20);
            this.lblInfoPsy.TabIndex = 14;
            this.lblInfoPsy.Text = "Info psy";
            // 
            // lblPhys
            // 
            this.lblPhys.AutoSize = true;
            this.lblPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhys.Location = new System.Drawing.Point(65, 265);
            this.lblPhys.Name = "lblPhys";
            this.lblPhys.Size = new System.Drawing.Size(99, 20);
            this.lblPhys.TabIndex = 13;
            this.lblPhys.Text = "Généralistes";
            // 
            // lblPsy
            // 
            this.lblPsy.AutoSize = true;
            this.lblPsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPsy.Location = new System.Drawing.Point(65, 64);
            this.lblPsy.Name = "lblPsy";
            this.lblPsy.Size = new System.Drawing.Size(107, 20);
            this.lblPsy.TabIndex = 12;
            this.lblPsy.Text = "Psychologues";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 20);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1159, 48);
            this.materialTabSelector1.TabIndex = 14;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteAccount.Depth = 0;
            this.btnDeleteAccount.HighEmphasis = true;
            this.btnDeleteAccount.Icon = null;
            this.btnDeleteAccount.Location = new System.Drawing.Point(666, 130);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteAccount.Size = new System.Drawing.Size(186, 36);
            this.btnDeleteAccount.TabIndex = 9;
            this.btnDeleteAccount.Text = "Supprimer le compte";
            this.btnDeleteAccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAccount.UseAccentColor = false;
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.VisibleChanged += new System.EventHandler(this.Profile_VisibleChanged);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermPhysForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalForm)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnDecon;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlMentalScore1;
        private System.Windows.Forms.Panel pnlMentalScore2;
        private System.Windows.Forms.Panel pnlPhysScore1;
        private System.Windows.Forms.Panel pnlPhysScore2;
        private System.Windows.Forms.PictureBox picTermPhysForm;
        private MaterialSkin.Controls.MaterialLabel lblTempMental;
        private MaterialSkin.Controls.MaterialLabel lblPhysTemp;
        private System.Windows.Forms.PictureBox picTermMentalForm;
        private System.Windows.Forms.Label lblInfoPhys;
        private System.Windows.Forms.Label lblInfoPsy;
        private System.Windows.Forms.Label lblPhys;
        private System.Windows.Forms.Label lblPsy;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblEmail;
        private MaterialSkin.Controls.MaterialButton btnModify;
        private MaterialSkin.Controls.MaterialButton btnChangePhysAnswers;
        private MaterialSkin.Controls.MaterialButton btnChangeMentalAnswers;
        private MaterialSkin.Controls.MaterialButton btnDeleteAccount;
    }
}