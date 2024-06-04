namespace P_Sante.Views
{
    partial class Interests
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
            this.picPinguin = new System.Windows.Forms.PictureBox();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.chkMentalHealth = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkNutrition = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkActivities = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkSleep = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPinguin)).BeginInit();
            this.SuspendLayout();
            // 
            // picPinguin
            // 
            this.picPinguin.BackColor = System.Drawing.Color.Transparent;
            this.picPinguin.Image = global::P_Sante.Properties.Resources.giphy_ezgif_com_webp_to_gif_converter;
            this.picPinguin.Location = new System.Drawing.Point(59, 100);
            this.picPinguin.Name = "picPinguin";
            this.picPinguin.Size = new System.Drawing.Size(296, 344);
            this.picPinguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPinguin.TabIndex = 6;
            this.picPinguin.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(977, 564);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext.Size = new System.Drawing.Size(82, 36);
            this.btnNext.TabIndex = 33;
            this.btnNext.Text = "Suivant";
            this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext.UseAccentColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // chkMentalHealth
            // 
            this.chkMentalHealth.AutoSize = true;
            this.chkMentalHealth.Depth = 0;
            this.chkMentalHealth.Location = new System.Drawing.Point(437, 202);
            this.chkMentalHealth.Margin = new System.Windows.Forms.Padding(0);
            this.chkMentalHealth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMentalHealth.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMentalHealth.Name = "chkMentalHealth";
            this.chkMentalHealth.ReadOnly = false;
            this.chkMentalHealth.Ripple = true;
            this.chkMentalHealth.Size = new System.Drawing.Size(129, 37);
            this.chkMentalHealth.TabIndex = 34;
            this.chkMentalHealth.Text = "Santé mental";
            this.chkMentalHealth.UseVisualStyleBackColor = true;
            // 
            // chkNutrition
            // 
            this.chkNutrition.AutoSize = true;
            this.chkNutrition.Depth = 0;
            this.chkNutrition.Location = new System.Drawing.Point(437, 268);
            this.chkNutrition.Margin = new System.Windows.Forms.Padding(0);
            this.chkNutrition.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkNutrition.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkNutrition.Name = "chkNutrition";
            this.chkNutrition.ReadOnly = false;
            this.chkNutrition.Ripple = true;
            this.chkNutrition.Size = new System.Drawing.Size(125, 37);
            this.chkNutrition.TabIndex = 35;
            this.chkNutrition.Text = "Alimentation";
            this.chkNutrition.UseVisualStyleBackColor = true;
            // 
            // chkActivities
            // 
            this.chkActivities.AutoSize = true;
            this.chkActivities.Depth = 0;
            this.chkActivities.Location = new System.Drawing.Point(437, 338);
            this.chkActivities.Margin = new System.Windows.Forms.Padding(0);
            this.chkActivities.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkActivities.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkActivities.Name = "chkActivities";
            this.chkActivities.ReadOnly = false;
            this.chkActivities.Ripple = true;
            this.chkActivities.Size = new System.Drawing.Size(171, 37);
            this.chkActivities.TabIndex = 36;
            this.chkActivities.Text = "Activités physiques";
            this.chkActivities.UseVisualStyleBackColor = true;
            // 
            // chkSleep
            // 
            this.chkSleep.AutoSize = true;
            this.chkSleep.Depth = 0;
            this.chkSleep.Location = new System.Drawing.Point(437, 407);
            this.chkSleep.Margin = new System.Windows.Forms.Padding(0);
            this.chkSleep.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSleep.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSleep.Name = "chkSleep";
            this.chkSleep.ReadOnly = false;
            this.chkSleep.Ripple = true;
            this.chkSleep.Size = new System.Drawing.Size(175, 37);
            this.chkSleep.TabIndex = 37;
            this.chkSleep.Text = "Gestion de sommeil";
            this.chkSleep.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrevious.Depth = 0;
            this.btnPrevious.HighEmphasis = true;
            this.btnPrevious.Icon = null;
            this.btnPrevious.Location = new System.Drawing.Point(59, 564);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrevious.Size = new System.Drawing.Size(104, 36);
            this.btnPrevious.TabIndex = 38;
            this.btnPrevious.Text = "Précédent";
            this.btnPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrevious.UseAccentColor = false;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Interests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.chkSleep);
            this.Controls.Add(this.chkActivities);
            this.Controls.Add(this.chkNutrition);
            this.Controls.Add(this.chkMentalHealth);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picPinguin);
            this.Name = "Interests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interests";
            ((System.ComponentModel.ISupportInitialize)(this.picPinguin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picPinguin;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialCheckbox chkMentalHealth;
        private MaterialSkin.Controls.MaterialCheckbox chkNutrition;
        private MaterialSkin.Controls.MaterialCheckbox chkActivities;
        private MaterialSkin.Controls.MaterialCheckbox chkSleep;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
    }
}