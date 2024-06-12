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
            this.btnContact = new MaterialSkin.Controls.MaterialButton();
            this.btnState = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(120, 153);
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
            this.btnDecon.Location = new System.Drawing.Point(38, 587);
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
            // btnContact
            // 
            this.btnContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContact.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnContact.Depth = 0;
            this.btnContact.HighEmphasis = true;
            this.btnContact.Icon = null;
            this.btnContact.Location = new System.Drawing.Point(241, 497);
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
            // btnState
            // 
            this.btnState.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnState.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnState.Depth = 0;
            this.btnState.HighEmphasis = true;
            this.btnState.Icon = null;
            this.btnState.Location = new System.Drawing.Point(548, 497);
            this.btnState.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnState.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnState.Name = "btnState";
            this.btnState.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnState.Size = new System.Drawing.Size(94, 36);
            this.btnState.TabIndex = 12;
            this.btnState.Text = "Mon état";
            this.btnState.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnState.UseAccentColor = false;
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnDecon);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.Profile_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialButton btnDecon;
        private MaterialSkin.Controls.MaterialButton btnContact;
        private MaterialSkin.Controls.MaterialButton btnState;
    }
}