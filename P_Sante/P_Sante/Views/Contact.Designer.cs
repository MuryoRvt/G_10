namespace P_Sante.Views
{
    partial class Contact
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
            this.lblPsy = new System.Windows.Forms.Label();
            this.lblPhys = new System.Windows.Forms.Label();
            this.lblInfoPsy = new System.Windows.Forms.Label();
            this.lblInfoPhys = new System.Windows.Forms.Label();
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblPsy
            // 
            this.lblPsy.AutoSize = true;
            this.lblPsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPsy.Location = new System.Drawing.Point(74, 117);
            this.lblPsy.Name = "lblPsy";
            this.lblPsy.Size = new System.Drawing.Size(107, 20);
            this.lblPsy.TabIndex = 0;
            this.lblPsy.Text = "Psychologues";
            // 
            // lblPhys
            // 
            this.lblPhys.AutoSize = true;
            this.lblPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhys.Location = new System.Drawing.Point(74, 318);
            this.lblPhys.Name = "lblPhys";
            this.lblPhys.Size = new System.Drawing.Size(99, 20);
            this.lblPhys.TabIndex = 1;
            this.lblPhys.Text = "Généralistes";
            // 
            // lblInfoPsy
            // 
            this.lblInfoPsy.AutoSize = true;
            this.lblInfoPsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInfoPsy.Location = new System.Drawing.Point(74, 164);
            this.lblInfoPsy.Name = "lblInfoPsy";
            this.lblInfoPsy.Size = new System.Drawing.Size(65, 20);
            this.lblInfoPsy.TabIndex = 2;
            this.lblInfoPsy.Text = "Info psy";
            // 
            // lblInfoPhys
            // 
            this.lblInfoPhys.AutoSize = true;
            this.lblInfoPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInfoPhys.Location = new System.Drawing.Point(74, 362);
            this.lblInfoPhys.Name = "lblInfoPhys";
            this.lblInfoPhys.Size = new System.Drawing.Size(74, 20);
            this.lblInfoPhys.TabIndex = 3;
            this.lblInfoPhys.Text = "Info phys";
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrevious.Depth = 0;
            this.btnPrevious.HighEmphasis = true;
            this.btnPrevious.Icon = null;
            this.btnPrevious.Location = new System.Drawing.Point(58, 583);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrevious.Size = new System.Drawing.Size(81, 36);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Revenir";
            this.btnPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrevious.UseAccentColor = false;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 656);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblInfoPhys);
            this.Controls.Add(this.lblInfoPsy);
            this.Controls.Add(this.lblPhys);
            this.Controls.Add(this.lblPsy);
            this.Name = "Contact";
            this.Text = "Contact";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contact_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.Contact_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPsy;
        private System.Windows.Forms.Label lblPhys;
        private System.Windows.Forms.Label lblInfoPsy;
        private System.Windows.Forms.Label lblInfoPhys;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
    }
}