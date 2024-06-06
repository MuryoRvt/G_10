namespace P_Sante.Views
{
    partial class Registration
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
            this.txtEmail = new TextBoxForeColor.CustomMaterialTextBox();
            this.txtLastName = new TextBoxForeColor.CustomMaterialTextBox();
            this.txtFirstName = new TextBoxForeColor.CustomMaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtRepeatPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
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
            this.btnSignUp.Location = new System.Drawing.Point(716, 428);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignUp.Size = new System.Drawing.Size(126, 36);
            this.btnSignUp.TabIndex = 18;
            this.btnSignUp.Text = "        S\'inscrire         ";
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
            this.btnSignIn.Location = new System.Drawing.Point(498, 428);
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
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.ForeColorCustom = System.Drawing.Color.Black;
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(498, 257);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 50);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.Enter += new System.EventHandler(this.txt_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.AnimateReadOnly = false;
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastName.ForeColorCustom = System.Drawing.Color.Black;
            this.txtLastName.LeadingIcon = null;
            this.txtLastName.Location = new System.Drawing.Point(498, 201);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(344, 50);
            this.txtLastName.TabIndex = 26;
            this.txtLastName.Text = "Nom";
            this.txtLastName.TrailingIcon = null;
            this.txtLastName.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.AnimateReadOnly = false;
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstName.ForeColorCustom = System.Drawing.Color.Black;
            this.txtFirstName.LeadingIcon = null;
            this.txtFirstName.Location = new System.Drawing.Point(498, 145);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(344, 50);
            this.txtFirstName.TabIndex = 25;
            this.txtFirstName.Text = "Prénom";
            this.txtFirstName.TrailingIcon = null;
            this.txtFirstName.Enter += new System.EventHandler(this.txt_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.AllowPromptAsInput = true;
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.AsciiOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.BeepOnError = false;
            this.txtPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HidePromptOnLeave = false;
            this.txtPassword.HideSelection = true;
            this.txtPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(498, 315);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Mask = "";
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.PromptChar = '_';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RejectInputOnFirstFailure = false;
            this.txtPassword.ResetOnPrompt = true;
            this.txtPassword.ResetOnSpace = true;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(344, 48);
            this.txtPassword.SkipLiterals = true;
            this.txtPassword.TabIndex = 30;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Mot de passe";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.ValidatingType = null;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.AllowPromptAsInput = true;
            this.txtRepeatPassword.AnimateReadOnly = false;
            this.txtRepeatPassword.AsciiOnly = false;
            this.txtRepeatPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRepeatPassword.BeepOnError = false;
            this.txtRepeatPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRepeatPassword.Depth = 0;
            this.txtRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRepeatPassword.HidePromptOnLeave = false;
            this.txtRepeatPassword.HideSelection = true;
            this.txtRepeatPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRepeatPassword.LeadingIcon = null;
            this.txtRepeatPassword.Location = new System.Drawing.Point(498, 370);
            this.txtRepeatPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRepeatPassword.Mask = "";
            this.txtRepeatPassword.MaxLength = 32767;
            this.txtRepeatPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '\0';
            this.txtRepeatPassword.PrefixSuffixText = null;
            this.txtRepeatPassword.PromptChar = '_';
            this.txtRepeatPassword.ReadOnly = false;
            this.txtRepeatPassword.RejectInputOnFirstFailure = false;
            this.txtRepeatPassword.ResetOnPrompt = true;
            this.txtRepeatPassword.ResetOnSpace = true;
            this.txtRepeatPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRepeatPassword.SelectedText = "";
            this.txtRepeatPassword.SelectionLength = 0;
            this.txtRepeatPassword.SelectionStart = 0;
            this.txtRepeatPassword.ShortcutsEnabled = true;
            this.txtRepeatPassword.Size = new System.Drawing.Size(344, 48);
            this.txtRepeatPassword.SkipLiterals = true;
            this.txtRepeatPassword.TabIndex = 31;
            this.txtRepeatPassword.TabStop = false;
            this.txtRepeatPassword.Text = "Répétez le mdp";
            this.txtRepeatPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepeatPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRepeatPassword.TrailingIcon = null;
            this.txtRepeatPassword.UseSystemPasswordChar = false;
            this.txtRepeatPassword.ValidatingType = null;
            this.txtRepeatPassword.Enter += new System.EventHandler(this.txtRepeatPassword_Enter);
            this.txtRepeatPassword.Leave += new System.EventHandler(this.txtRepeatPassword_Leave);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.picGoose);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picGoose;
        private MaterialSkin.Controls.MaterialButton btnSignUp;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
        private TextBoxForeColor.CustomMaterialTextBox txtFirstName;
        private TextBoxForeColor.CustomMaterialTextBox txtLastName;
        private TextBoxForeColor.CustomMaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRepeatPassword;
    }
}