using System.Windows.Forms;
using System;

namespace pong
{
    public partial class EndForm : Form
    {

        // Nouveau constructeur qui accepte une chaîne en tant que paramètre
        public EndForm(string winner)
        {
            InitializeComponent();
            winnerLabel.Text = winner + " a gagné!";
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Show();
            this.Hide();
        }

        private void quitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
