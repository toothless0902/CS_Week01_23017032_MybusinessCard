using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int clickCount = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            pictureBox1.MouseLeave += new EventHandler(pictureBox1_MouseLeave);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/toothless0902",
                UseShellExecute = true
            });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickCount++;

            if (clickCount % 3 == 0)
            {
                pictureBox1.Image = Properties.Resources.img1;
            }
            else if (clickCount % 3 == 1)
            {
                pictureBox1.Image = Properties.Resources.img2;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.img3;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
