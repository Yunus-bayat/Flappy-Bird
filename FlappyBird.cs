using System;
using System.Windows.Forms;
namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer(object sender, EventArgs e)
        {
            pictureBox_kus.Top += gravity;
            pictureBox_alt.Left -= pipeSpeed;
            pictureBox_ust.Left -= pipeSpeed;
            label1.Text = "GAME OVER:" + score;

            if (pictureBox_alt.Left < -150)
            {
                pictureBox_alt.Left = 800;
                score++;
            }
            if (pictureBox_ust.Left < -180)
            {
                pictureBox_ust.Left = 950;
                score++;
            }
            if (pictureBox_kus.Bounds.IntersectsWith(pictureBox_alt.Bounds) ||
                pictureBox_kus.Bounds.IntersectsWith(pictureBox_ust.Bounds) ||
                pictureBox_kus.Bounds.IntersectsWith(pictureBox_zemýn.Bounds) || pictureBox_kus.Top < -25)
            {
                EndGame(this);
            }
            static void EndGame(Form1 @this)
            {
                @this.timer_GameControl.Stop();
                @this.label1.Text = "GAME OVER";

            }

        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }
    }
}
