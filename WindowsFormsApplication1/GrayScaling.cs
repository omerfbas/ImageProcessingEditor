using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayScaling
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Resmi bitmap formatına al
            Bitmap bmp = new Bitmap(f.FileName);

            //Resmin Boyutları
            int width = bmp.Width;
            int height = bmp.Height;

            //Negative alma işlemi
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlerini al
                    Color p = bmp.GetPixel(x, y);

                    //ARGB değerlerini eşleştir
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //ortalamayı bul
                    int ort = (r + g + b) / 3;


                    //yeni ARGB değerlerini pixele ata
                    bmp.SetPixel(x, y, Color.FromArgb(a, ort, ort, ort));


                }
            }
            //Yeni resmi picturebox2'ye bastır.
            pictureBox2.Image = bmp;

            // bmp.Save("D:\\Image\\maiconNegative.jpg");
            File = pictureBox2.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();

            if (f.ShowDialog() == DialogResult.OK)
            {
                File.Save(f.FileName);
            }
        }
    }
}
