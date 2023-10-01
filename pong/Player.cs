using System.Drawing;
using System.Windows.Forms;

namespace pong
{
    public class Player
    {
        public PictureBox PlayerPaddle { get; private set; }
        public Rectangle Bounds => PlayerPaddle.Bounds;
        public bool GoUp { get; set; }
        public bool GoDown { get; set; }
        public int Speed { get; set; } = 8;

        public Player(PictureBox playerPaddle)
        {
            PlayerPaddle = playerPaddle;
        }

        public void Move()
        {
            if (GoUp && PlayerPaddle.Top > 0)
            {
                PlayerPaddle.Top -= Speed;
            }
            if (GoDown && PlayerPaddle.Top < PlayerPaddle.Parent.ClientSize.Height - PlayerPaddle.Height)
            {
                PlayerPaddle.Top += Speed;
            }
        }
    }
}
