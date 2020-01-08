using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightMirror1
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

            //Sağa aynalı olacak resmi tanımla
            Bitmap Rayna = new Bitmap(width * 2 , height);


            //Negative alma işlemi
            for (int y = 0; y < height; y++)
            {
                for (int lx = 0, rx = width * 2 - 1; lx < width; lx ++ , rx --)
                {
                    //Orjinal resmin pixel değerlerini al
                    Color p = bmp.GetPixel(lx, y);

                    //Sağa aylalı olacak resmin pixel değerlerini ata
                    Rayna.SetPixel(lx, y, p);
                    Rayna.SetPixel(rx, y, p);

                }
            }

            //Yeni resmi picturebox2'ye bastır.
            pictureBox2.Image = Rayna;

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
