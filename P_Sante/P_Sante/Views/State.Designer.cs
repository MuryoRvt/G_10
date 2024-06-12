namespace P_Sante.Views
{
    partial class State
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
            this.pnlMentalScore1 = new System.Windows.Forms.Panel();
            this.pnlMentalScore2 = new System.Windows.Forms.Panel();
            this.pnlPhysScore1 = new System.Windows.Forms.Panel();
            this.pnlPhysScore2 = new System.Windows.Forms.Panel();
            this.lblTempMental = new MaterialSkin.Controls.MaterialLabel();
            this.lblPhysTemp = new MaterialSkin.Controls.MaterialLabel();
            this.picTermPhysForm = new System.Windows.Forms.PictureBox();
            this.picTermMentalForm = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.picTermPhysForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMentalScore1
            // 
            this.pnlMentalScore1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMentalScore1.Location = new System.Drawing.Point(823, 418);
            this.pnlMentalScore1.Name = "pnlMentalScore1";
            this.pnlMentalScore1.Size = new System.Drawing.Size(16, 41);
            this.pnlMentalScore1.TabIndex = 14;
            // 
            // pnlMentalScore2
            // 
            this.pnlMentalScore2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMentalScore2.Location = new System.Drawing.Point(835, 418);
            this.pnlMentalScore2.Name = "pnlMentalScore2";
            this.pnlMentalScore2.Size = new System.Drawing.Size(24, 41);
            this.pnlMentalScore2.TabIndex = 13;
            // 
            // pnlPhysScore1
            // 
            this.pnlPhysScore1.BackColor = System.Drawing.Color.IndianRed;
            this.pnlPhysScore1.Location = new System.Drawing.Point(1006, 418);
            this.pnlPhysScore1.Name = "pnlPhysScore1";
            this.pnlPhysScore1.Size = new System.Drawing.Size(16, 41);
            this.pnlPhysScore1.TabIndex = 12;
            // 
            // pnlPhysScore2
            // 
            this.pnlPhysScore2.BackColor = System.Drawing.Color.IndianRed;
            this.pnlPhysScore2.Location = new System.Drawing.Point(1018, 418);
            this.pnlPhysScore2.Name = "pnlPhysScore2";
            this.pnlPhysScore2.Size = new System.Drawing.Size(24, 41);
            this.pnlPhysScore2.TabIndex = 11;
            // 
            // lblTempMental
            // 
            this.lblTempMental.AutoSize = true;
            this.lblTempMental.Depth = 0;
            this.lblTempMental.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTempMental.Location = new System.Drawing.Point(814, 606);
            this.lblTempMental.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTempMental.Name = "lblTempMental";
            this.lblTempMental.Size = new System.Drawing.Size(50, 19);
            this.lblTempMental.TabIndex = 17;
            this.lblTempMental.Text = "Mental";
            // 
            // lblPhysTemp
            // 
            this.lblPhysTemp.AutoSize = true;
            this.lblPhysTemp.Depth = 0;
            this.lblPhysTemp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhysTemp.Location = new System.Drawing.Point(987, 606);
            this.lblPhysTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhysTemp.Name = "lblPhysTemp";
            this.lblPhysTemp.Size = new System.Drawing.Size(66, 19);
            this.lblPhysTemp.TabIndex = 16;
            this.lblPhysTemp.Text = "Physique";
            // 
            // picTermPhysForm
            // 
            this.picTermPhysForm.Image = global::P_Sante.Properties.Resources.Termo8Bits;
            this.picTermPhysForm.Location = new System.Drawing.Point(942, 192);
            this.picTermPhysForm.Name = "picTermPhysForm";
            this.picTermPhysForm.Size = new System.Drawing.Size(164, 411);
            this.picTermPhysForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermPhysForm.TabIndex = 18;
            this.picTermPhysForm.TabStop = false;
            // 
            // picTermMentalForm
            // 
            this.picTermMentalForm.BackColor = System.Drawing.Color.Transparent;
            this.picTermMentalForm.Image = global::P_Sante.Properties.Resources.Termo8BitsAzul;
            this.picTermMentalForm.Location = new System.Drawing.Point(759, 192);
            this.picTermMentalForm.Name = "picTermMentalForm";
            this.picTermMentalForm.Size = new System.Drawing.Size(164, 411);
            this.picTermMentalForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTermMentalForm.TabIndex = 15;
            this.picTermMentalForm.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrevious.Depth = 0;
            this.btnPrevious.HighEmphasis = true;
            this.btnPrevious.Icon = null;
            this.btnPrevious.Location = new System.Drawing.Point(48, 567);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrevious.Size = new System.Drawing.Size(104, 36);
            this.btnPrevious.TabIndex = 44;
            this.btnPrevious.Text = "Précédent";
            this.btnPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrevious.UseAccentColor = false;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 656);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pnlMentalScore1);
            this.Controls.Add(this.pnlMentalScore2);
            this.Controls.Add(this.pnlPhysScore1);
            this.Controls.Add(this.pnlPhysScore2);
            this.Controls.Add(this.picTermPhysForm);
            this.Controls.Add(this.lblTempMental);
            this.Controls.Add(this.lblPhysTemp);
            this.Controls.Add(this.picTermMentalForm);
            this.MaximizeBox = false;
            this.Name = "State";
            this.Sizable = false;
            this.Text = "State";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.State_FormClosed);
            this.Load += new System.EventHandler(this.State_Load);
            this.VisibleChanged += new System.EventHandler(this.State_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picTermPhysForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermMentalForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMentalScore1;
        private System.Windows.Forms.Panel pnlMentalScore2;
        private System.Windows.Forms.Panel pnlPhysScore1;
        private System.Windows.Forms.Panel pnlPhysScore2;
        private System.Windows.Forms.PictureBox picTermPhysForm;
        private MaterialSkin.Controls.MaterialLabel lblTempMental;
        private MaterialSkin.Controls.MaterialLabel lblPhysTemp;
        private System.Windows.Forms.PictureBox picTermMentalForm;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
    }
}