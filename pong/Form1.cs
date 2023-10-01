using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        private Player player;
        private Computer cpu;
        private Ball ball;
        private int score = 0;
        private int cpuScore = 0;
        private int speedIncrement = 1;
        private const int MaxScore = 7;
        public string Winner = "";

        public Form1()
        {
            InitializeComponent();
            player = new Player(playerPaddle);
            cpu = new Computer(cpuPaddle);
            ball = new Ball(ballPb);
            gameTimer.Interval = 20;
            gameTimer.Start();
           
        }

        private void UpdateScores()
        {
            playerScore.Text = score.ToString();
            cpuLabel.Text = cpuScore.ToString();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            // Met à jour les mouvements du joueur, de l'ordinateur et de la balle
            player.Move();
            cpu.Move(ballPb);
            ball.Move();

            // Vérifie et gère les collisions entre la balle et les raquettes
            ball.CheckCollision(player, cpu);

            // Vérifie et gère si la balle est hors des limites de l'écran
            ball.CheckAndHandleOutOfBounds(ClientSize.Width, ClientSize.Height, ref score, ref cpuScore, ref speedIncrement);
            
            // Met à jour les scores affichés
            UpdateScores();

            // Vérifie si le score final a été atteint et arrête le jeu si c'est le cas
            CheckFinalScore();
        }

        private void CheckFinalScore()
        {
            if (score == MaxScore)
            {
                Winner = "Le joueur";
                gameTimer.Stop();
                EndForm endForm = new EndForm(Winner);
                endForm.Show();
                this.Hide();
            }
            if (cpuScore == MaxScore)
            {
                Winner = "L'ordinateur";
                gameTimer.Stop();
                EndForm endForm = new EndForm(Winner);
                endForm.Show();
                this.Hide();
                ;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            player.GoUp = e.KeyCode == Keys.Up;
            player.GoDown = e.KeyCode == Keys.Down;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) player.GoUp = false;
            if (e.KeyCode == Keys.Down) player.GoDown = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
