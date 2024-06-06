namespace P_Sante.Views
{
    partial class PhysiqueQuestions
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
            this.btnLoc = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnLoc
            // 
            this.btnLoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoc.Depth = 0;
            this.btnLoc.HighEmphasis = true;
            this.btnLoc.Icon = null;
            this.btnLoc.Location = new System.Drawing.Point(451, 305);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoc.Size = new System.Drawing.Size(93, 36);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "Location";
            this.btnLoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoc.UseAccentColor = false;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // PhysiqueQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 617);
            this.Controls.Add(this.btnLoc);
            this.Name = "PhysiqueQuestions";
            this.Text = "PhysiqueQuestions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhysiqueQuestions_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLoc;
    }
}