using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChannel
{
    public partial class Form1 : Form
    {
        Image File;
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog f = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
            }

            Bitmap bmp = new Bitmap(f.FileName);
            pictureBox1.Image = Image.FromFile(f.FileName);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(f.FileName);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rbpm = new Bitmap(bmp);

            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    rbpm.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

                }

                pictureBox2.Image = rbpm;
                File = pictureBox2.Image;

            }

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(f.FileName);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap gbpm = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    gbpm.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                }

                pictureBox2.Image = gbpm;
                File = pictureBox2.Image;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(f.FileName);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap bbpm = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    bbpm.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                }

                pictureBox2.Image = bbpm;
                File = pictureBox2.Image;

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();

            if (f.ShowDialog() == DialogResult.OK)
            {
                File.Save(f.FileName);
            }
        }
    }
}
