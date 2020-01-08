using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuelResize
{
    public partial class Form1 : Form
    {
        Image imageOrginal;
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Image File;
        private void button1_Click(object sender, EventArgs e)
        {
            

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                imageOrginal = pictureBox1.Image;
            }

        }

        Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height /100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value > 0)
            {
                pictureBox1.Image = Zoom(imageOrginal, new Size (trackBar1.Value, trackBar2.Value));
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBar2.Value > 0)
            {
                pictureBox1.Image = Zoom(imageOrginal, new Size(trackBar1.Value, trackBar2.Value));
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            File = pictureBox1.Image;

            if (f.ShowDialog() == DialogResult.OK)
            {
                File.Save(f.FileName);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
