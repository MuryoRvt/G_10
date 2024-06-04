namespace P_Sante.Views
{
    partial class Register
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
            this.picGoose = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new MaterialSkin.Controls.MaterialButton();
            this.btnSignIn = new MaterialSkin.Controls.MaterialButton();
            this.lblFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.lblLastName = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblRepeatPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRepeatPassword = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGoose)).BeginInit();
            this.SuspendLayout();
            // 
            // picGoose
            // 
            this.picGoose.BackColor = System.Drawing.Color.Transparent;
            this.picGoose.Image = global::P_Sante.Properties.Resources.duck_dancing_duck_unscreen;
            this.picGoose.Location = new System.Drawing.Point(2, 117);
            this.picGoose.Name = "picGoose";
            this.picGoose.Size = new System.Drawing.Size(431, 434);
            this.picGoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoose.TabIndex = 5;
            this.picGoose.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignUp.Depth = 0;
            this.btnSignUp.HighEmphasis = true;
            this.btnSignUp.Icon = null;
            this.btnSignUp.Location = new System.Drawing.Point(555, 450);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignUp.Size = new System.Drawing.Size(97, 36);
            this.btnSignUp.TabIndex = 18;
            this.btnSignUp.Text = "S\'inscrire";
            this.btnSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignUp.UseAccentColor = false;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignIn.Depth = 0;
            this.btnSignIn.HighEmphasis = true;
            this.btnSignIn.Icon = null;
            this.btnSignIn.Location = new System.Drawing.Point(541, 498);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignIn.Size = new System.Drawing.Size(128, 36);
            this.btnSignIn.TabIndex = 19;
            this.btnSignIn.Text = "Se connecter";
            this.btnSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignIn.UseAccentColor = false;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Depth = 0;
            this.lblFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFirstName.Location = new System.Drawing.Point(436, 158);
            this.lblFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(56, 19);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "Prénom";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Depth = 0;
            this.lblLastName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastName.Location = new System.Drawing.Point(457, 215);
            this.lblLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(35, 19);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Nom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.Location = new System.Drawing.Point(447, 273);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.Location = new System.Drawing.Point(396, 328);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 19);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Mot de passe";
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Depth = 0;
            this.lblRepeatPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRepeatPassword.Location = new System.Drawing.Point(383, 384);
            this.lblRepeatPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(109, 19);
            this.lblRepeatPassword.TabIndex = 24;
            this.lblRepeatPassword.Text = "Répétez le mdp";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AnimateReadOnly = false;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.LeadingIcon = null;
            this.txtFirstName.Location = new System.Drawing.Point(498, 145);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(201, 50);
            this.txtFirstName.TabIndex = 25;
            this.txtFirstName.Text = "";
            this.txtFirstName.TrailingIcon = null;
            // 
            // txtLastName
            // 
            this.txtLastName.AnimateReadOnly = false;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.LeadingIcon = null;
            this.txtLastName.Location = new System.Drawing.Point(498, 201);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(201, 50);
            this.txtLastName.TabIndex = 26;
            this.txtLastName.Text = "";
            this.txtLastName.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(498, 257);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 50);
            this.txtEmail.TabIndex = 27;
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
            this.txtPassword.Location = new System.Drawing.Point(498, 313);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 50);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.AnimateReadOnly = false;
            this.txtRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepeatPassword.Depth = 0;
            this.txtRepeatPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRepeatPassword.LeadingIcon = null;
            this.txtRepeatPassword.Location = new System.Drawing.Point(498, 369);
            this.txtRepeatPassword.MaxLength = 50;
            this.txtRepeatPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRepeatPassword.Multiline = false;
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(201, 50);
            this.txtRepeatPassword.TabIndex = 29;
            this.txtRepeatPassword.Text = "";
            this.txtRepeatPassword.TrailingIcon = null;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblRepeatPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.picGoose);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.picGoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picGoose;
        private MaterialSkin.Controls.MaterialButton btnSignUp;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
        private MaterialSkin.Controls.MaterialLabel lblFirstName;
        private MaterialSkin.Controls.MaterialLabel lblLastName;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialLabel lblRepeatPassword;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtRepeatPassword;
    }
}