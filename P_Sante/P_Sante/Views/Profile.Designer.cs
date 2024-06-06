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
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // pnlMentalScore
            // 
            this.pnlMentalScore.BackColor = System.Drawing.Color.Red;
            this.pnlMentalScore.Location = new System.Drawing.Point(1098, 588);
            this.pnlMentalScore.Name = "pnlMentalScore";
            this.pnlMentalScore.Size = new System.Drawing.Size(11, 41);
            this.pnlMentalScore.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrevious.Depth = 0;
            this.btnPrevious.HighEmphasis = true;
            this.btnPrevious.Icon = null;
            this.btnPrevious.Location = new System.Drawing.Point(25, 593);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrevious.Size = new System.Drawing.Size(104, 36);
            this.btnPrevious.TabIndex = 34;
            this.btnPrevious.Text = "Précédent";
            this.btnPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrevious.UseAccentColor = false;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pnlMentalScore);
            this.Name = "Profile";
            this.Text = "Profile";
            this.VisibleChanged += new System.EventHandler(this.Profile_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMentalScore;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
    }
}