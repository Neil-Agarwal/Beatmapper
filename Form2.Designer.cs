namespace Beatmapper
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.PicboxWin = new System.Windows.Forms.PictureBox();
            this.lblFinalScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxWin)).BeginInit();
            this.SuspendLayout();
            // 
            // PicboxWin
            // 
            this.PicboxWin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicboxWin.BackgroundImage")));
            this.PicboxWin.Location = new System.Drawing.Point(-2, -6);
            this.PicboxWin.Name = "PicboxWin";
            this.PicboxWin.Size = new System.Drawing.Size(332, 377);
            this.PicboxWin.TabIndex = 0;
            this.PicboxWin.TabStop = false;
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.Location = new System.Drawing.Point(12, 9);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(0, 24);
            this.lblFinalScore.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 357);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.PicboxWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Congratulations!";
            ((System.ComponentModel.ISupportInitialize)(this.PicboxWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicboxWin;
        private System.Windows.Forms.Label lblFinalScore;
    }
}