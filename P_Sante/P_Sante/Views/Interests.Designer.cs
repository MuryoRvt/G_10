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
            this.chkMentalHealth = new System.Windows.Forms.CheckBox();
            this.chkNutrition = new System.Windows.Forms.CheckBox();
            this.chkActivities = new System.Windows.Forms.CheckBox();
            this.chkSleep = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMentalHealth
            // 
            this.chkMentalHealth.AutoSize = true;
            this.chkMentalHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMentalHealth.Location = new System.Drawing.Point(408, 201);
            this.chkMentalHealth.Name = "chkMentalHealth";
            this.chkMentalHealth.Size = new System.Drawing.Size(123, 24);
            this.chkMentalHealth.TabIndex = 0;
            this.chkMentalHealth.Text = "Santé mental";
            this.chkMentalHealth.UseVisualStyleBackColor = true;
            // 
            // chkNutrition
            // 
            this.chkNutrition.AutoSize = true;
            this.chkNutrition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNutrition.Location = new System.Drawing.Point(408, 264);
            this.chkNutrition.Name = "chkNutrition";
            this.chkNutrition.Size = new System.Drawing.Size(116, 24);
            this.chkNutrition.TabIndex = 1;
            this.chkNutrition.Text = "Alimentation";
            this.chkNutrition.UseVisualStyleBackColor = true;
            // 
            // chkActivities
            // 
            this.chkActivities.AutoSize = true;
            this.chkActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivities.Location = new System.Drawing.Point(408, 326);
            this.chkActivities.Name = "chkActivities";
            this.chkActivities.Size = new System.Drawing.Size(154, 24);
            this.chkActivities.TabIndex = 2;
            this.chkActivities.Text = "Activités physique";
            this.chkActivities.UseVisualStyleBackColor = true;
            // 
            // chkSleep
            // 
            this.chkSleep.AutoSize = true;
            this.chkSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSleep.Location = new System.Drawing.Point(408, 395);
            this.chkSleep.Name = "chkSleep";
            this.chkSleep.Size = new System.Drawing.Size(168, 24);
            this.chkSleep.TabIndex = 3;
            this.chkSleep.Text = "Gestion de sommeil";
            this.chkSleep.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(59, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Interests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkSleep);
            this.Controls.Add(this.chkActivities);
            this.Controls.Add(this.chkNutrition);
            this.Controls.Add(this.chkMentalHealth);
            this.Name = "Interests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interests";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMentalHealth;
        private System.Windows.Forms.CheckBox chkNutrition;
        private System.Windows.Forms.CheckBox chkActivities;
        private System.Windows.Forms.CheckBox chkSleep;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}