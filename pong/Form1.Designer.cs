namespace pong
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.cpuPaddle = new System.Windows.Forms.PictureBox();
            this.ballPb = new System.Windows.Forms.PictureBox();
            this.playerPaddle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.playerScore.ForeColor = System.Drawing.Color.Lime;
            this.playerScore.Location = new System.Drawing.Point(105, 9);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(36, 26);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "00";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cpuLabel.ForeColor = System.Drawing.Color.Red;
            this.cpuLabel.Location = new System.Drawing.Point(735, 9);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(36, 26);
            this.cpuLabel.TabIndex = 4;
            this.cpuLabel.Text = "00";
            // 
            // cpuPaddle
            // 
            this.cpuPaddle.BackColor = System.Drawing.Color.Transparent;
            this.cpuPaddle.Image = global::pong.Properties.Resources.fancy_paddle_green;
            this.cpuPaddle.Location = new System.Drawing.Point(889, 230);
            this.cpuPaddle.Name = "cpuPaddle";
            this.cpuPaddle.Size = new System.Drawing.Size(32, 128);
            this.cpuPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cpuPaddle.TabIndex = 2;
            this.cpuPaddle.TabStop = false;
            // 
            // ballPb
            // 
            this.ballPb.BackColor = System.Drawing.Color.White;
            this.ballPb.Image = global::pong.Properties.Resources.fancy_ball;
            this.ballPb.Location = new System.Drawing.Point(434, 239);
            this.ballPb.Name = "ballPb";
            this.ballPb.Size = new System.Drawing.Size(27, 26);
            this.ballPb.TabIndex = 1;
            this.ballPb.TabStop = false;
            // 
            // playerPaddle
            // 
            this.playerPaddle.BackColor = System.Drawing.Color.Transparent;
            this.playerPaddle.Image = global::pong.Properties.Resources.fancy_paddle_green;
            this.playerPaddle.Location = new System.Drawing.Point(12, 186);
            this.playerPaddle.Name = "playerPaddle";
            this.playerPaddle.Size = new System.Drawing.Size(32, 128);
            this.playerPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerPaddle.TabIndex = 0;
            this.playerPaddle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::pong.Properties.Resources.fancy_court;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpuPaddle);
            this.Controls.Add(this.ballPb);
            this.Controls.Add(this.playerPaddle);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Pong Game MOO ICT";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.cpuPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPaddle;
        private System.Windows.Forms.PictureBox ballPb;
        private System.Windows.Forms.PictureBox cpuPaddle;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuLabel;
    }
}

