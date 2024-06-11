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
            this.btnSignUp = new MaterialSkin.Controls.MaterialButton();
            this.btnSignIn = new MaterialSkin.Controls.MaterialButton();
            this.txtEmail = new TextBoxForeColor.CustomMaterialTextBox();
            this.txtLastName = new TextBoxForeColor.CustomMaterialTextBox();
            this.txtFirstName = new TextBoxForeColor.CustomMaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtRepeatPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblDialog_Guide = new System.Windows.Forms.Label();
            this.picRepeatPassword = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picLastName = new System.Windows.Forms.PictureBox();
            this.picFirstName = new System.Windows.Forms.PictureBox();
            this.picGoose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPassInfo = new System.Windows.Forms.Label();
            this.comboCountry = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRepeatPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignUp.Depth = 0;
            this.btnSignUp.HighEmphasis = true;
            this.btnSignUp.Icon = null;
            this.btnSignUp.Location = new System.Drawing.Point(716, 508);
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
            this.btnSignIn.Location = new System.Drawing.Point(498, 508);
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
            this.txtEmail.TextChanged += new System.EventHandler(this.txt_TextChanged);
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
            this.txtLastName.TextChanged += new System.EventHandler(this.txt_TextChanged);
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
            this.txtFirstName.TextChanged += new System.EventHandler(this.txt_TextChanged);
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
            this.txtPassword.Location = new System.Drawing.Point(498, 370);
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
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
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
            this.txtRepeatPassword.Location = new System.Drawing.Point(498, 450);
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
            this.txtRepeatPassword.TextChanged += new System.EventHandler(this.txtRepeatPassword_TextChanged);
            // 
            // lblDialog_Guide
            // 
            this.lblDialog_Guide.AutoSize = true;
            this.lblDialog_Guide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDialog_Guide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDialog_Guide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog_Guide.ForeColor = System.Drawing.Color.Black;
            this.lblDialog_Guide.Location = new System.Drawing.Point(129, 104);
            this.lblDialog_Guide.Name = "lblDialog_Guide";
            this.lblDialog_Guide.Size = new System.Drawing.Size(95, 20);
            this.lblDialog_Guide.TabIndex = 36;
            this.lblDialog_Guide.Text = "Registration";
            // 
            // picRepeatPassword
            // 
            this.picRepeatPassword.Image = global::P_Sante.Properties.Resources.multiply;
            this.picRepeatPassword.Location = new System.Drawing.Point(847, 455);
            this.picRepeatPassword.Name = "picRepeatPassword";
            this.picRepeatPassword.Size = new System.Drawing.Size(36, 34);
            this.picRepeatPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRepeatPassword.TabIndex = 44;
            this.picRepeatPassword.TabStop = false;
            this.picRepeatPassword.Visible = false;
            // 
            // picPassword
            // 
            this.picPassword.Image = global::P_Sante.Properties.Resources.multiply;
            this.picPassword.Location = new System.Drawing.Point(847, 374);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(36, 34);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 43;
            this.picPassword.TabStop = false;
            this.picPassword.Visible = false;
            // 
            // picEmail
            // 
            this.picEmail.Image = global::P_Sante.Properties.Resources.multiply;
            this.picEmail.Location = new System.Drawing.Point(847, 263);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(36, 34);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmail.TabIndex = 42;
            this.picEmail.TabStop = false;
            this.picEmail.Visible = false;
            // 
            // picLastName
            // 
            this.picLastName.Image = global::P_Sante.Properties.Resources.multiply;
            this.picLastName.Location = new System.Drawing.Point(847, 206);
            this.picLastName.Name = "picLastName";
            this.picLastName.Size = new System.Drawing.Size(36, 34);
            this.picLastName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLastName.TabIndex = 41;
            this.picLastName.TabStop = false;
            this.picLastName.Visible = false;
            // 
            // picFirstName
            // 
            this.picFirstName.Image = global::P_Sante.Properties.Resources.multiply;
            this.picFirstName.Location = new System.Drawing.Point(848, 154);
            this.picFirstName.Name = "picFirstName";
            this.picFirstName.Size = new System.Drawing.Size(36, 34);
            this.picFirstName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFirstName.TabIndex = 40;
            this.picFirstName.TabStop = false;
            this.picFirstName.Visible = false;
            // 
            // picGoose
            // 
            this.picGoose.BackColor = System.Drawing.Color.Transparent;
            this.picGoose.Image = global::P_Sante.Properties.Resources.bongo_cat_unscreen__1__dialog;
            this.picGoose.Location = new System.Drawing.Point(29, 154);
            this.picGoose.Name = "picGoose";
            this.picGoose.Size = new System.Drawing.Size(177, 143);
            this.picGoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoose.TabIndex = 34;
            this.picGoose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::P_Sante.Properties.Resources.DialogCharacter;
            this.pictureBox1.Location = new System.Drawing.Point(29, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::P_Sante.Properties.Resources.Nouage_removebg_preview__1_;
            this.pictureBox4.Location = new System.Drawing.Point(814, 350);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::P_Sante.Properties.Resources.Nouage_removebg_preview__1_;
            this.pictureBox3.Location = new System.Drawing.Point(466, 179);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::P_Sante.Properties.Resources.Plant_8Bit_removebg_preview__1_;
            this.pictureBox2.Location = new System.Drawing.Point(776, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // lblPassInfo
            // 
            this.lblPassInfo.AutoSize = true;
            this.lblPassInfo.Location = new System.Drawing.Point(495, 420);
            this.lblPassInfo.Name = "lblPassInfo";
            this.lblPassInfo.Size = new System.Drawing.Size(356, 26);
            this.lblPassInfo.TabIndex = 45;
            this.lblPassInfo.Text = "Le mdp doit contenir au moins une lettre, un chiffre et un caractère special\r\n(12" +
    " caractères au minimum)";
            // 
            // comboCountry
            // 
            this.comboCountry.AutoResize = false;
            this.comboCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboCountry.Depth = 0;
            this.comboCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboCountry.DropDownHeight = 174;
            this.comboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCountry.DropDownWidth = 121;
            this.comboCountry.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.IntegralHeight = false;
            this.comboCountry.ItemHeight = 43;
            this.comboCountry.Items.AddRange(new object[] {
            "Suisse",
            "France"});
            this.comboCountry.Location = new System.Drawing.Point(498, 313);
            this.comboCountry.MaxDropDownItems = 4;
            this.comboCountry.MouseState = MaterialSkin.MouseState.OUT;
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(154, 49);
            this.comboCountry.StartIndex = 0;
            this.comboCountry.TabIndex = 46;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.lblPassInfo);
            this.Controls.Add(this.picRepeatPassword);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.picLastName);
            this.Controls.Add(this.picFirstName);
            this.Controls.Add(this.lblDialog_Guide);
            this.Controls.Add(this.picGoose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Gray;
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.VisibleChanged += new System.EventHandler(this.Registration_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picRepeatPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnSignUp;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
        private TextBoxForeColor.CustomMaterialTextBox txtFirstName;
        private TextBoxForeColor.CustomMaterialTextBox txtLastName;
        private TextBoxForeColor.CustomMaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRepeatPassword;
        private System.Windows.Forms.Label lblDialog_Guide;
        private System.Windows.Forms.PictureBox picGoose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picFirstName;
        private System.Windows.Forms.PictureBox picLastName;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picRepeatPassword;
        private System.Windows.Forms.Label lblPassInfo;
        private MaterialSkin.Controls.MaterialComboBox comboCountry;
    }
}