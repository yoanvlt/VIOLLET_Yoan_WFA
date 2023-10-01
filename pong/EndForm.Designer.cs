namespace pong
{
    partial class EndForm
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
            this.restartButton = new System.Windows.Forms.Button();
            this.quitButton2 = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ballPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPb)).BeginInit();
            this.SuspendLayout();
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.restartButton.Location = new System.Drawing.Point(343, 173);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(110, 64);
            this.restartButton.TabIndex = 0;
            this.restartButton.Text = "Recommencer";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // quitButton2
            // 
            this.quitButton2.Location = new System.Drawing.Point(343, 301);
            this.quitButton2.Name = "quitButton2";
            this.quitButton2.Size = new System.Drawing.Size(110, 62);
            this.quitButton2.TabIndex = 1;
            this.quitButton2.Text = "Quitter";
            this.quitButton2.UseVisualStyleBackColor = true;
            this.quitButton2.Click += new System.EventHandler(this.quitButton2_Click);
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(340, 98);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(0, 13);
            this.winnerLabel.TabIndex = 2;
            this.winnerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pong.Properties.Resources.fancy_paddle_blue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pong.Properties.Resources.fancy_paddle_blue;
            this.pictureBox2.Location = new System.Drawing.Point(756, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // ballPb
            // 
            this.ballPb.BackColor = System.Drawing.Color.White;
            this.ballPb.Image = global::pong.Properties.Resources.fancy_ball;
            this.ballPb.Location = new System.Drawing.Point(723, 266);
            this.ballPb.Name = "ballPb";
            this.ballPb.Size = new System.Drawing.Size(27, 26);
            this.ballPb.TabIndex = 6;
            this.ballPb.TabStop = false;
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ballPb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.quitButton2);
            this.Controls.Add(this.restartButton);
            this.Name = "EndForm";
            this.Text = "EndForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button quitButton2;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ballPb;
    }
}