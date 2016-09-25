namespace Beatmapper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Play = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.picboxEffects = new System.Windows.Forms.PictureBox();
            this.End = new System.Windows.Forms.Button();
            this.gbDifficulty = new System.Windows.Forms.GroupBox();
            this.rbtnFabulous = new System.Windows.Forms.RadioButton();
            this.rbtnInsane = new System.Windows.Forms.RadioButton();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.lblMultiplyer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEffects)).BeginInit();
            this.gbDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Play.BackColor = System.Drawing.Color.LightGray;
            this.Play.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.DimGray;
            this.Play.Location = new System.Drawing.Point(720, 188);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(52, 21);
            this.Play.TabIndex = 5;
            this.Play.Text = "PLAY";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click_1);
            // 
            // picbox
            // 
            this.picbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox.BackColor = System.Drawing.Color.Transparent;
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox.Location = new System.Drawing.Point(12, 12);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(584, 513);
            this.picbox.TabIndex = 8;
            this.picbox.TabStop = false;
            this.picbox.Click += new System.EventHandler(this.picbox_Click);
            this.picbox.Paint += new System.Windows.Forms.PaintEventHandler(this.picbox_Paint_1);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.LightGray;
            this.Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.DimGray;
            this.Exit.Location = new System.Drawing.Point(756, 503);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 21);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(492, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 396);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.DimGray;
            this.lblScore.Location = new System.Drawing.Point(426, 477);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 43);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "0";
            // 
            // picboxEffects
            // 
            this.picboxEffects.Location = new System.Drawing.Point(401, 23);
            this.picboxEffects.Name = "picboxEffects";
            this.picboxEffects.Size = new System.Drawing.Size(165, 88);
            this.picboxEffects.TabIndex = 14;
            this.picboxEffects.TabStop = false;
            // 
            // End
            // 
            this.End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.End.BackColor = System.Drawing.Color.LightGray;
            this.End.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.ForeColor = System.Drawing.Color.DimGray;
            this.End.Location = new System.Drawing.Point(720, 188);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(52, 21);
            this.End.TabIndex = 15;
            this.End.Text = "END";
            this.End.UseVisualStyleBackColor = false;
            this.End.Visible = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // gbDifficulty
            // 
            this.gbDifficulty.Controls.Add(this.rbtnFabulous);
            this.gbDifficulty.Controls.Add(this.rbtnInsane);
            this.gbDifficulty.Controls.Add(this.rbtnHard);
            this.gbDifficulty.Controls.Add(this.rbtnNormal);
            this.gbDifficulty.ForeColor = System.Drawing.Color.DimGray;
            this.gbDifficulty.Location = new System.Drawing.Point(602, 401);
            this.gbDifficulty.Name = "gbDifficulty";
            this.gbDifficulty.Size = new System.Drawing.Size(216, 56);
            this.gbDifficulty.TabIndex = 16;
            this.gbDifficulty.TabStop = false;
            this.gbDifficulty.Text = "Difficulty";
            // 
            // rbtnFabulous
            // 
            this.rbtnFabulous.AutoSize = true;
            this.rbtnFabulous.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnFabulous.Location = new System.Drawing.Point(136, 32);
            this.rbtnFabulous.Name = "rbtnFabulous";
            this.rbtnFabulous.Size = new System.Drawing.Size(74, 16);
            this.rbtnFabulous.TabIndex = 3;
            this.rbtnFabulous.Text = "Fabulous";
            this.rbtnFabulous.UseVisualStyleBackColor = true;
            // 
            // rbtnInsane
            // 
            this.rbtnInsane.AutoSize = true;
            this.rbtnInsane.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnInsane.Location = new System.Drawing.Point(67, 32);
            this.rbtnInsane.Name = "rbtnInsane";
            this.rbtnInsane.Size = new System.Drawing.Size(60, 16);
            this.rbtnInsane.TabIndex = 2;
            this.rbtnInsane.Text = "Insane";
            this.rbtnInsane.UseVisualStyleBackColor = true;
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnHard.Location = new System.Drawing.Point(136, 10);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(50, 16);
            this.rbtnHard.TabIndex = 1;
            this.rbtnHard.Text = "Hard";
            this.rbtnHard.UseVisualStyleBackColor = true;
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Checked = true;
            this.rbtnNormal.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnNormal.Location = new System.Drawing.Point(67, 10);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(63, 16);
            this.rbtnNormal.TabIndex = 0;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "Normal";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // lblMultiplyer
            // 
            this.lblMultiplyer.AutoSize = true;
            this.lblMultiplyer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplyer.ForeColor = System.Drawing.Color.DimGray;
            this.lblMultiplyer.Location = new System.Drawing.Point(464, 449);
            this.lblMultiplyer.Name = "lblMultiplyer";
            this.lblMultiplyer.Size = new System.Drawing.Size(75, 28);
            this.lblMultiplyer.TabIndex = 17;
            this.lblMultiplyer.Text = "1.00x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(820, 536);
            this.Controls.Add(this.lblMultiplyer);
            this.Controls.Add(this.gbDifficulty);
            this.Controls.Add(this.End);
            this.Controls.Add(this.picboxEffects);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beatmapper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEffects)).EndInit();
            this.gbDifficulty.ResumeLayout(false);
            this.gbDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picboxEffects;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.GroupBox gbDifficulty;
        private System.Windows.Forms.RadioButton rbtnFabulous;
        private System.Windows.Forms.RadioButton rbtnInsane;
        private System.Windows.Forms.RadioButton rbtnHard;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.Label lblMultiplyer;

    }
}

