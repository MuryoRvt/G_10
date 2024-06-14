namespace P_Sante.Views
{
    partial class ModifyPassword
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
            this.txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtRepeatPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnFinishPass = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picRepeatPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepeatPassword)).BeginInit();
            this.SuspendLayout();
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
            this.txtPassword.Location = new System.Drawing.Point(93, 36);
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
            this.txtPassword.Size = new System.Drawing.Size(250, 48);
            this.txtPassword.SkipLiterals = true;
            this.txtPassword.TabIndex = 0;
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
            this.txtRepeatPassword.Location = new System.Drawing.Point(93, 101);
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
            this.txtRepeatPassword.Size = new System.Drawing.Size(250, 48);
            this.txtRepeatPassword.SkipLiterals = true;
            this.txtRepeatPassword.TabIndex = 1;
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
            // btnFinishPass
            // 
            this.btnFinishPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinishPass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinishPass.Depth = 0;
            this.btnFinishPass.HighEmphasis = true;
            this.btnFinishPass.Icon = null;
            this.btnFinishPass.Location = new System.Drawing.Point(255, 158);
            this.btnFinishPass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinishPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinishPass.Name = "btnFinishPass";
            this.btnFinishPass.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinishPass.Size = new System.Drawing.Size(88, 36);
            this.btnFinishPass.TabIndex = 2;
            this.btnFinishPass.Text = "Modifier";
            this.btnFinishPass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinishPass.UseAccentColor = false;
            this.btnFinishPass.UseVisualStyleBackColor = true;
            this.btnFinishPass.Click += new System.EventHandler(this.btnFinishPass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(93, 158);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(87, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picPassword
            // 
            this.picPassword.Image = global::P_Sante.Properties.Resources.multiply;
            this.picPassword.Location = new System.Drawing.Point(349, 42);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(36, 34);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 41;
            this.picPassword.TabStop = false;
            this.picPassword.Visible = false;
            // 
            // picRepeatPassword
            // 
            this.picRepeatPassword.Image = global::P_Sante.Properties.Resources.multiply;
            this.picRepeatPassword.Location = new System.Drawing.Point(349, 107);
            this.picRepeatPassword.Name = "picRepeatPassword";
            this.picRepeatPassword.Size = new System.Drawing.Size(36, 34);
            this.picRepeatPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRepeatPassword.TabIndex = 42;
            this.picRepeatPassword.TabStop = false;
            this.picRepeatPassword.Visible = false;
            // 
            // ModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 214);
            this.Controls.Add(this.picRepeatPassword);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinishPass);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "ModifyPassword";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "ModifyPassword";
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepeatPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRepeatPassword;
        private MaterialSkin.Controls.MaterialButton btnFinishPass;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picRepeatPassword;
    }
}