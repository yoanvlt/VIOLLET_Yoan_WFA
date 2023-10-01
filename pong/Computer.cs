using System.Drawing;
using System.Windows.Forms;
using System;

namespace pong
{
    public class Computer
    {
        public PictureBox CpuPaddle { get; private set; }
        public Rectangle Bounds => CpuPaddle.Bounds;
        public float Speed { get; set; } = 10f;  // changé int en float

        public Computer(PictureBox cpuPaddle)
        {
            CpuPaddle = cpuPaddle;
        }

        public void Move(PictureBox ball)
        {
            // L'ordinateur suit la balle
            CpuPaddle.Top += (ball.Top + ball.Height / 2 > CpuPaddle.Top + CpuPaddle.Height / 2) ? (int)Speed : -(int)Speed;

            // Vérifier les limites pour s'assurer que le paddle ne sort pas de l'écran
            if (CpuPaddle.Top < 0) CpuPaddle.Top = 0;
            else if (CpuPaddle.Top + CpuPaddle.Height > CpuPaddle.Parent.ClientSize.Height)
                CpuPaddle.Top = CpuPaddle.Parent.ClientSize.Height - CpuPaddle.Height;
        }

    }
}
