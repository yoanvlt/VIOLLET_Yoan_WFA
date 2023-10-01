using System;
using System.Drawing;
using System.Windows.Forms;

namespace pong
{
    public class Ball
    {
        public PictureBox BallPb { get; private set; }
        public const int InitialBallSpeed = 5;

        public float BallSpeedX { get; set; } = InitialBallSpeed;
        public float BallSpeedY { get; set; } = InitialBallSpeed;

        public float CurrentX { get; set; }
        public float CurrentY { get; set; }

        public const float MaxSpeed = 20f;  // La vitesse maximale de la balle



        public Ball(PictureBox ballPb)
        {
            BallPb = ballPb;
            Reset();
        }

        public void Move()
        {
            CurrentX += BallSpeedX;
            CurrentY += BallSpeedY;

            BallPb.Left = (int)CurrentX;
            BallPb.Top = (int)CurrentY;
        }

        public void Reset()
        {
            Random rnd = new Random();
            int directionX = rnd.Next(0, 2) * 2 - 1;  // Résultat aléatoire entre -1 ou 1
            int directionY = rnd.Next(0, 2) * 2 - 1;  // Résultat aléatoire entre -1 ou 1

            CurrentX = BallPb.Parent.ClientSize.Width / 2 - BallPb.Width / 2;
            CurrentY = BallPb.Parent.ClientSize.Height / 2 - BallPb.Height / 2;
            BallSpeedX = InitialBallSpeed * directionX;
            BallSpeedY = InitialBallSpeed * directionY;

        }

        public void CheckCollision(Player player, Computer cpu)
        {
            if (BallPb.Bounds.IntersectsWith(player.Bounds) || BallPb.Bounds.IntersectsWith(cpu.Bounds))
            {
                BallSpeedX = -BallSpeedX;
                // Augmenter la vitesse de la balle à chaque rebond
                BallSpeedX *= 1.1f;
                BallSpeedY *= 1.1f;

                // Clamper la vitesse à la vitesse maximale
                BallSpeedX = Math.Min(MaxSpeed, Math.Abs(BallSpeedX)) * (BallSpeedX < 0 ? -1 : 1);
                BallSpeedY = Math.Min(MaxSpeed, Math.Abs(BallSpeedY)) * (BallSpeedY < 0 ? -1 : 1);
            }
        }

        public void CheckAndHandleOutOfBounds(int clientWidth, int clientHeight, ref int playerScore, ref int cpuScore, ref int speedIncrement)
        {
            if (BallPb.Left < 0)
            {
                cpuScore++;
                if (cpuScore < 7) Reset();
                speedIncrement = -Math.Abs(speedIncrement);
            }
            if (BallPb.Left + BallPb.Width > clientWidth)
            {
                playerScore++;
                if (playerScore < 7) Reset();
                speedIncrement = Math.Abs(speedIncrement);
            }
            if (BallPb.Top < 0 || BallPb.Top + BallPb.Height > clientHeight)
            {
                BallSpeedY = -BallSpeedY;
            }
        }
    }
}
