using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightMirror
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

            //*
            Bitmap Raynax = new Bitmap(width, height);


            //Negative alma işlemi
            for (int y = 0; y < height; y++)
            {
                for (int lx = 0 , Rorta = width , Lorta = width ; lx < width; lx ++ , Lorta -- ,Rorta ++)
                {
                    //Orjinal resmin pixel değerlerini al
                    Color p = bmp.GetPixel(lx, y);

                    //Sağa aylalı olacak resmin pixel değerlerini ata
                    Rayna.SetPixel(Lorta, y, p);
                    Rayna.SetPixel(Rorta, y, p);

                }
            }

            //*Sadece aynalı olan kısmı Raynax e atama

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //Orjinal resmin pixel değerlerini al
                    Color p = Rayna.GetPixel(x, y);//bmp yerine Rayna

                    //Sağa aylalı olacak resmin pixel değerlerini ata
                    Raynax.SetPixel(x, y, p);

                }
            }

            //*
            pictureBox1.Image = Raynax;

            //Yeni resmi picturebox2'ye bastır.
            pictureBox2.Image = Rayna;

            // bmp.Save("D:\\Image\\maiconNegative.jpg");
            File = pictureBox2.Image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(f.FileName);
            pictureBox1.Image = bmp;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();

            if (f.ShowDialog() == DialogResult.OK)
            {
                File.Save(f.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
