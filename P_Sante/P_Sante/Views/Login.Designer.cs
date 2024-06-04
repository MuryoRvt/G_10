namespace P_Sante.Views
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCat = new System.Windows.Forms.PictureBox();
            this.btnSignIn = new MaterialSkin.Controls.MaterialButton();
            this.btnSignUp = new MaterialSkin.Controls.MaterialButton();
            this.btnDebug = new MaterialSkin.Controls.MaterialButton();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // picCat
            // 
            this.picCat.BackColor = System.Drawing.Color.Transparent;
            this.picCat.Image = global::P_Sante.Properties.Resources.bongo_cat_unscreen;
            this.picCat.Location = new System.Drawing.Point(318, 69);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(456, 282);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 0;
            this.picCat.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignIn.Depth = 0;
            this.btnSignIn.HighEmphasis = true;
            this.btnSignIn.Icon = null;
            this.btnSignIn.Location = new System.Drawing.Point(493, 453);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignIn.Size = new System.Drawing.Size(128, 36);
            this.btnSignIn.TabIndex = 24;
            this.btnSignIn.Text = "Se connecter";
            this.btnSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignIn.UseAccentColor = false;
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignUp.Depth = 0;
            this.btnSignUp.HighEmphasis = true;
            this.btnSignUp.Icon = null;
            this.btnSignUp.Location = new System.Drawing.Point(509, 501);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignUp.Size = new System.Drawing.Size(97, 36);
            this.btnSignUp.TabIndex = 25;
            this.btnSignUp.Text = "S\'inscrire";
            this.btnSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignUp.UseAccentColor = false;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDebug.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDebug.Depth = 0;
            this.btnDebug.HighEmphasis = true;
            this.btnDebug.Icon = null;
            this.btnDebug.Location = new System.Drawing.Point(927, 584);
            this.btnDebug.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDebug.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDebug.Size = new System.Drawing.Size(76, 36);
            this.btnDebug.TabIndex = 26;
            this.btnDebug.Text = "Passer";
            this.btnDebug.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDebug.UseAccentColor = false;
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.Location = new System.Drawing.Point(403, 345);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.Location = new System.Drawing.Point(352, 397);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 19);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Mot de passe";
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(465, 328);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 50);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(465, 384);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(189, 50);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.picCat);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCat;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
        private MaterialSkin.Controls.MaterialButton btnSignUp;
        private MaterialSkin.Controls.MaterialButton btnDebug;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
    }
}

