using System;
using System.Drawing;
using System.Windows.Forms;

namespace c_Projesi
{
    public partial class Form1 : Form
    {
        int yolHızı = 10;
        int trafikHızı = 8;
        int oyuncuHızı = 12;
        int score = 0;

        Random arabaYeri = new Random();
        bool solagit, sağagit;

        public Form1()
        {
            InitializeComponent();
            OyunuDurdur();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Patlama.Visible = false;
            Başlabuton.Enabled = false;  
            score = 0;                   
            Skor.Text = "Skor: " + score; 

            
            Oyuncu.Left = 237;
            Oyuncu.Top = 260;

            
            YZ1.Top = arabaYeri.Next(100, 300) * -1;
            YZ1.Left = arabaYeri.Next(5, 200);

            YZ2.Top = arabaYeri.Next(100, 300) * -1;
            YZ2.Left = arabaYeri.Next(245, 422);

           
            
            OyunZamanlayıcısı.Start();
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solagit = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                sağagit = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solagit = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                sağagit = false;
            }
        }

        private void OyunZamanlayıcıOlay(object sender, EventArgs e)
        {
            Skor.Text = "Skor: " + score;

            if (solagit && Oyuncu.Left > 5)
            {
                Oyuncu.Left -= oyuncuHızı;
            }
            if (sağagit && Oyuncu.Left < 422)
            {
                Oyuncu.Left += oyuncuHızı;
            }

           
            Yol1.Top += yolHızı;
            Yol2.Top += yolHızı;

            if (Yol1.Top > 500)
            {
                Yol1.Top = -500;
            }
            if (Yol2.Top > 500)
            {
                Yol2.Top = -500;
            }

         
            YZ1.Top += trafikHızı;
            YZ2.Top += trafikHızı;

            if (YZ1.Top > 500)
            {
                değiştirYZarabalar(YZ1);
            }
            if (YZ2.Top > 500)
            {
                değiştirYZarabalar(YZ2);
            }

           
            if (Oyuncu.Bounds.IntersectsWith(YZ1.Bounds))
            {
                PatlamaYap(YZ1);
                GameOver();
            }
            else if (Oyuncu.Bounds.IntersectsWith(YZ2.Bounds))
            {
                PatlamaYap(YZ2);
                GameOver();
            }

           
            score++;
        }

        private void PatlamaYap(PictureBox car)
        {
            
            Patlama.Location = car.Location;
            Patlama.Visible = true;
        }


        private void değiştirYZarabalar(PictureBox Tempcar)
        {
            Tempcar.Top = arabaYeri.Next(100, 300) * -1;
            Tempcar.Left = arabaYeri.Next(5, 422);
        }

        private void GameOver()
        {
            OyunZamanlayıcısı.Stop();
            Başlabuton.Enabled = true;  

            MessageBox.Show("Oyun Bitti! Skorunuz: " + score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Oyuncu_Click(object sender, EventArgs e)
        {

        }

        private void YZ2_Click(object sender, EventArgs e)
        {

        }

        private void YZ1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Patlama_Click(object sender, EventArgs e)
        {

        }

        private void OyunuDurdur()
        {
            Başlabuton.Enabled = true;
            Patlama.Visible = false;
            Ödül.Visible = false;
            solagit = false;
            sağagit = false;
            score = 0;
            Skor.Text = "Skor: " + score;

            YZ1.Top = arabaYeri.Next(100, 300) * -1;
            YZ1.Left = arabaYeri.Next(5, 200);

            YZ2.Top = arabaYeri.Next(100, 300) * -1;
            YZ2.Left = arabaYeri.Next(245, 422);
        }
    }
}
