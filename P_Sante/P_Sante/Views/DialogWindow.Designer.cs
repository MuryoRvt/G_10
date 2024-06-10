namespace P_Sante.Views
{
    partial class DialogWindow
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
            this.lblConfirmation = new MaterialSkin.Controls.MaterialLabel();
            this.btnYes = new MaterialSkin.Controls.MaterialButton();
            this.btnNo = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Depth = 0;
            this.lblConfirmation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConfirmation.Location = new System.Drawing.Point(163, 49);
            this.lblConfirmation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(104, 19);
            this.lblConfirmation.TabIndex = 0;
            this.lblConfirmation.Text = "Vous êtes sûr?";
            // 
            // btnYes
            // 
            this.btnYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnYes.Depth = 0;
            this.btnYes.HighEmphasis = true;
            this.btnYes.Icon = null;
            this.btnYes.Location = new System.Drawing.Point(361, 158);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnYes.Size = new System.Drawing.Size(64, 36);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Oui";
            this.btnYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnYes.UseAccentColor = false;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNo.Depth = 0;
            this.btnNo.HighEmphasis = true;
            this.btnNo.Icon = null;
            this.btnNo.Location = new System.Drawing.Point(30, 158);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNo.Size = new System.Drawing.Size(64, 36);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Non";
            this.btnNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNo.UseAccentColor = false;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // DialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 214);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblConfirmation);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "DialogWindow";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblConfirmation;
        private MaterialSkin.Controls.MaterialButton btnYes;
        private MaterialSkin.Controls.MaterialButton btnNo;
    }
}