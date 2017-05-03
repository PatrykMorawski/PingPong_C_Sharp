using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int SpeedBallLeft = 4;
        public int SpeedBallTop = 4;
        public int Score = 0;


        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();     

        public Form1()
        {
            InitializeComponent();

            player.URL = "MusicPingPong.mp3";
            player.settings.volume = 10;

            Cursor.Hide(); // Ukryty Kursor

            this.FormBorderStyle = FormBorderStyle.None; // Nie ma obramówki
            this.TopMost = true; // Form1 na przodzie zawsze
            this.Bounds = Screen.PrimaryScreen.Bounds; // FullScreen

            pbRocket.Top = playground.Bottom - (playground.Bottom / 10);  // Pozycja Rocket-a

            GameOver_lbl.Left = (playground.Width / 2) - (GameOver_lbl.Width /2); // Zawsze Środek
            GameOver_lbl.Top = (playground.Height / 2) - (GameOver_lbl.Height / 2);
            M_lbl.Left = playground.Width - M_lbl.Width;
            GameOver_lbl.Visible = false;

            odczyt_hightscore();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pbRocket.Left = Cursor.Position.X - (pbRocket.Width / 2); // Środek Rakiety

            pbBall.Left += SpeedBallLeft;  // Ruch kuli
            pbBall.Top += SpeedBallTop;

            // Kolizja Rakiety

            if (pbBall.Bottom >= pbRocket.Top && pbBall.Bottom <= pbRocket.Bottom && pbBall.Left >= pbRocket.Left && pbBall.Right <= pbRocket.Right)
            //if (Ball.Bounds.IntersectsWith(Racket.Bounds))
            {
                SpeedBallTop += 2;
                SpeedBallLeft += 2;
                SpeedBallTop = -SpeedBallTop +1; // Odbicie Kuli
                Score += 1;

                scorelbl.Text = Score.ToString(); // Zmieniający się tekst

                Random r = new Random();

                // Random RGB Color i ustawia na tło
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }

            if (pbBall.Left <= playground.Left)
            {
                SpeedBallLeft = -SpeedBallLeft;
            }

            if (pbBall.Right >= playground.Right)
            {
                SpeedBallLeft = -SpeedBallLeft;
            }

            if (pbBall.Top <= playground.Top)
            {
                SpeedBallTop = -SpeedBallTop;
            }

            if (pbBall.Bottom >= playground.Bottom)
            {
                zapis_hightscore();
                timer1.Enabled = false; // Stop the game
                GameOver_lbl.Visible = true;
                odczyt_hightscore();
            }


        }

        public void odczyt_hightscore()
        {

            lblNajScore.Text = System.IO.File.ReadAllText(@"E:\Kopia Zapasowa Programów\Gry\Ping - Pong - C#\Hightscore.txt");

        }

        public void zapis_hightscore()
        {
            int WysokiScore = Int32.Parse(lblNajScore.Text);
            if (WysokiScore < Score)
            {
                string[] lines = { scorelbl.Text };
                System.IO.File.WriteAllLines(@"E:\Kopia Zapasowa Programów\Gry\Ping - Pong - C#\Hightscore.txt", lines);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); } // Wyjście Escape
            if (e.KeyCode == Keys.M)
            {
                if (player.controls.get_isAvailable("Stop")) { player.controls.stop(); }
                else player.controls.play(); }
            if (e.KeyCode == Keys.F1) // Reload
            {
                pbBall.Top = 50;
                pbBall.Left = 50;
                SpeedBallLeft = 4;
                SpeedBallTop = 4;
                Score = 0;
                scorelbl.Text = "0";
                timer1.Enabled = true;
                GameOver_lbl.Visible = false;
                playground.BackColor = Color.White;
            }
         
        }

    }
}
