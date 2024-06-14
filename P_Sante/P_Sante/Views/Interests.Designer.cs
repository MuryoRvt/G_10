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
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.chkMentalHealth = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkPhysHealth = new MaterialSkin.Controls.MaterialCheckbox();
            this.picDuck = new System.Windows.Forms.PictureBox();
            this.picPinguin = new System.Windows.Forms.PictureBox();
            this.lblInterests = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDuck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPinguin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(992, 571);
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
            this.chkMentalHealth.Location = new System.Drawing.Point(215, 491);
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
            this.chkMentalHealth.CheckedChanged += new System.EventHandler(this.chkMentalHealth_CheckedChanged);
            // 
            // chkPhysHealth
            // 
            this.chkPhysHealth.AutoSize = true;
            this.chkPhysHealth.Depth = 0;
            this.chkPhysHealth.Location = new System.Drawing.Point(785, 491);
            this.chkPhysHealth.Margin = new System.Windows.Forms.Padding(0);
            this.chkPhysHealth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPhysHealth.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPhysHealth.Name = "chkPhysHealth";
            this.chkPhysHealth.ReadOnly = false;
            this.chkPhysHealth.Ripple = true;
            this.chkPhysHealth.Size = new System.Drawing.Size(144, 37);
            this.chkPhysHealth.TabIndex = 35;
            this.chkPhysHealth.Text = "Santé physique";
            this.chkPhysHealth.UseVisualStyleBackColor = true;
            this.chkPhysHealth.CheckedChanged += new System.EventHandler(this.chkPhysHealth_CheckedChanged);
            // 
            // picDuck
            // 
            this.picDuck.BackColor = System.Drawing.Color.Transparent;
            this.picDuck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDuck.Image = global::P_Sante.Properties.Resources.DuckNotDancing;
            this.picDuck.Location = new System.Drawing.Point(672, 116);
            this.picDuck.Name = "picDuck";
            this.picDuck.Size = new System.Drawing.Size(343, 372);
            this.picDuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDuck.TabIndex = 48;
            this.picDuck.TabStop = false;
            this.picDuck.Click += new System.EventHandler(this.picDuck_Click);
            // 
            // picPinguin
            // 
            this.picPinguin.BackColor = System.Drawing.Color.Transparent;
            this.picPinguin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPinguin.Image = global::P_Sante.Properties.Resources.PinwinSad;
            this.picPinguin.Location = new System.Drawing.Point(130, 116);
            this.picPinguin.Name = "picPinguin";
            this.picPinguin.Size = new System.Drawing.Size(309, 372);
            this.picPinguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPinguin.TabIndex = 46;
            this.picPinguin.TabStop = false;
            this.picPinguin.Click += new System.EventHandler(this.picPinguin_Click);
            // 
            // lblInterests
            // 
            this.lblInterests.AutoSize = true;
            this.lblInterests.BackColor = System.Drawing.Color.Transparent;
            this.lblInterests.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblInterests.Location = new System.Drawing.Point(418, 51);
            this.lblInterests.Name = "lblInterests";
            this.lblInterests.Size = new System.Drawing.Size(327, 29);
            this.lblInterests.TabIndex = 49;
            this.lblInterests.Text = "Qu\'est-ce qui vous interesse?";
            // 
            // Interests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.lblInterests);
            this.Controls.Add(this.picDuck);
            this.Controls.Add(this.picPinguin);
            this.Controls.Add(this.chkPhysHealth);
            this.Controls.Add(this.chkMentalHealth);
            this.Controls.Add(this.btnNext);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "Interests";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Interests_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.Interests_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picDuck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPinguin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialCheckbox chkMentalHealth;
        private MaterialSkin.Controls.MaterialCheckbox chkPhysHealth;
        private System.Windows.Forms.PictureBox picDuck;
        private System.Windows.Forms.PictureBox picPinguin;
        private System.Windows.Forms.Label lblInterests;
    }
}