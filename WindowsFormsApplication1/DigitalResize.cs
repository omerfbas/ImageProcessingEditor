using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalResize
{
    public partial class Form1 : Form
    {
        Image img;
        string[] tip = { ".PNG", ".JPEG", ".JPG" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < tip.Length; i++)
            {
                comboBox.Items.Add(tip[i]);
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textsec.Text = ofd.FileName;
                img = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                textkydt.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(textw.Text), h = Convert.ToInt32(texth.Text);
            img = Boyutlandir(img, w, h);
            ((Button)sender).Enabled = false;
            MessageBox.Show("Seçilen Resmin Verilen Değerlere Göre Yeniden Boyutlandırılması Tamamlandı.");

        }

        Image Boyutlandir(Image image, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, w, h);
            graphic.Dispose();

            return bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
             int nokta = 0, slash = 0;
             for(int j = textsec.Text.Length - 1; j >= 0; j--)
                if (textsec.Text[j] == '.')
                    nokta = j;
                else if (textsec.Text[j] == '\\')
                {
                    slash = j;
                    break;
                }

            img.Save(textkydt.Text + "\\" + textsec.Text.Substring(slash + 1, nokta - slash - 1) + "_Boyutlandırılmış" + tip[comboBox.SelectedIndex]);
            ((Button)sender).Enabled = false;
            MessageBox.Show("Yeni Resim Başarıyla Kaydedildi.");


            /* SaveFileDialog f = new SaveFileDialog();

            if (f.ShowDialog() == DialogResult.OK)
            {
                img.Save(f.FileName);
            }*/
        }
    }
}
