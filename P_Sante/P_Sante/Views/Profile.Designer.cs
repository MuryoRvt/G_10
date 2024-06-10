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
            this.pnlMentalScore = new System.Windows.Forms.Panel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.btnDecon = new MaterialSkin.Controls.MaterialButton();
            this.pnlPhysScore = new System.Windows.Forms.Panel();
            this.picTermPhysCircle = new TextBoxForeColor.OvalPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picTermMentalCircle = new TextBoxForeColor.OvalPictureBox();
            this.picTermMentalForm = new System.Windows.Forms.PictureBox();
            this.lblPhysTemp = new MaterialSkin.Controls.MaterialLabel();
            this.lblTempMental = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picTermPhysCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMentalScore
            // 
            this.pnlMentalScore.BackColor = System.Drawing.Color.Red;
            this.pnlMentalScore.Location = new System.Drawing.Point(1044, 435);
            this.pnlMentalScore.Name = "pnlMentalScore";
            this.pnlMentalScore.Size = new System.Drawing.Size(28, 41);
            this.pnlMentalScore.TabIndex = 0;
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
            // pnlPhysScore
            // 
            this.pnlPhysScore.BackColor = System.Drawing.Color.Blue;
            this.pnlPhysScore.Location = new System.Drawing.Point(858, 435);
            this.pnlPhysScore.Name = "pnlPhysScore";
            this.pnlPhysScore.Size = new System.Drawing.Size(28, 41);
            this.pnlPhysScore.TabIndex = 5;
            // 
            // picTermPhysCircle
            // 
            this.picTermPhysCircle.BackColor = System.Drawing.Color.Transparent;
            this.picTermPhysCircle.Image = global::P_Sante.Properties.Resources.BlueCircle;
            this.picTermPhysCircle.Location = new System.Drawing.Point(824, 469);
            this.picTermPhysCircle.Name = "picTermPhysCircle";
            this.picTermPhysCircle.Size = new System.Drawing.Size(97, 79);
            this.picTermPhysCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermPhysCircle.TabIndex = 6;
            this.picTermPhysCircle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::P_Sante.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(810, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // picTermMentalCircle
            // 
            this.picTermMentalCircle.BackColor = System.Drawing.Color.Transparent;
            this.picTermMentalCircle.Image = global::P_Sante.Properties.Resources.CercleRouge;
            this.picTermMentalCircle.Location = new System.Drawing.Point(1010, 469);
            this.picTermMentalCircle.Name = "picTermMentalCircle";
            this.picTermMentalCircle.Size = new System.Drawing.Size(97, 79);
            this.picTermMentalCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermMentalCircle.TabIndex = 2;
            this.picTermMentalCircle.TabStop = false;
            // 
            // picTermMentalForm
            // 
            this.picTermMentalForm.BackColor = System.Drawing.Color.Transparent;
            this.picTermMentalForm.Image = global::P_Sante.Properties.Resources.pngwing_com;
            this.picTermMentalForm.Location = new System.Drawing.Point(996, 166);
            this.picTermMentalForm.Name = "picTermMentalForm";
            this.picTermMentalForm.Size = new System.Drawing.Size(123, 442);
            this.picTermMentalForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermMentalForm.TabIndex = 3;
            this.picTermMentalForm.TabStop = false;
            // 
            // lblPhysTemp
            // 
            this.lblPhysTemp.AutoSize = true;
            this.lblPhysTemp.Depth = 0;
            this.lblPhysTemp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhysTemp.Location = new System.Drawing.Point(835, 611);
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
            this.lblTempMental.Location = new System.Drawing.Point(1022, 611);
            this.lblTempMental.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTempMental.Name = "lblTempMental";
            this.lblTempMental.Size = new System.Drawing.Size(50, 19);
            this.lblTempMental.TabIndex = 9;
            this.lblTempMental.Text = "Mental";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.lblTempMental);
            this.Controls.Add(this.lblPhysTemp);
            this.Controls.Add(this.pnlPhysScore);
            this.Controls.Add(this.picTermPhysCircle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDecon);
            this.Controls.Add(this.pnlMentalScore);
            this.Controls.Add(this.picTermMentalCircle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picTermMentalForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.VisibleChanged += new System.EventHandler(this.Profile_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picTermPhysCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMentalScore;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private TextBoxForeColor.OvalPictureBox picTermMentalCircle;
        private System.Windows.Forms.PictureBox picTermMentalForm;
        private MaterialSkin.Controls.MaterialButton btnDecon;
        private System.Windows.Forms.Panel pnlPhysScore;
        private TextBoxForeColor.OvalPictureBox picTermPhysCircle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblPhysTemp;
        private MaterialSkin.Controls.MaterialLabel lblTempMental;
    }
}