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
                // Déterminer le côté de la collision (haut ou bas de la raquette)
                float paddleCenterY;
                if (BallPb.Bounds.IntersectsWith(player.Bounds))
                {
                    paddleCenterY = player.Bounds.Top + player.Bounds.Height / 2f;
                }
                else
                {
                    paddleCenterY = cpu.Bounds.Top + cpu.Bounds.Height / 2f;
                }

                float ballCenterY = BallPb.Top + BallPb.Height / 2f;
                bool hitTop = ballCenterY < paddleCenterY;

                // Inverser la direction de la balle en fonction du côté de la collision
                BallSpeedX = -BallSpeedX;
                if (hitTop)
                {
                    BallSpeedY = -Math.Abs(BallSpeedY);
                }
                else
                {
                    BallSpeedY = Math.Abs(BallSpeedY);
                }

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
            // Vérifie si la balle est sortie des limites de l'écran et met à jour les scores
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
            // Si la balle touche le haut ou le bas de l'écran, inverse la direction en Y
            if (BallPb.Top < 0 || BallPb.Top + BallPb.Height > clientHeight)
            {
                BallSpeedY = -BallSpeedY;
            }
        }
    }
}
