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
            player.Move();
            cpu.Move(ballPb);
            ball.Move();
            ball.CheckCollision(player, cpu);
            ball.CheckAndHandleOutOfBounds(ClientSize.Width, ClientSize.Height, ref score, ref cpuScore, ref speedIncrement);
            UpdateScores();
            CheckFinalScore();
        }

        private void CheckFinalScore()
        {
            if (score > MaxScore)
            {
                gameTimer.Stop();
                MessageBox.Show("Vous avez gagné ce jeu");
            }
            if (cpuScore > MaxScore)
            {
                gameTimer.Stop();
                MessageBox.Show("Le CPU gagne, vous perdez");
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
