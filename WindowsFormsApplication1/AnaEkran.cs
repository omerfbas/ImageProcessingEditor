using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrayScaling.Form1 openForm = new GrayScaling.Form1();
            openForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RightMirror.Form1 openForm2 = new RightMirror.Form1();
            openForm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RightMirror1.Form1 openForm3 = new RightMirror1.Form1();
            openForm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NegativeImage.Form1 openForm4 = new NegativeImage.Form1();
            openForm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Arayuz.Resize openForm5 = new Arayuz.Resize();
            openForm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorChannel.Form1 openForm6 = new ColorChannel.Form1();
            openForm6.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("--GELİŞTİRİCİLER-- \n\nÖmerhan Yetişğin \nÖmer Faruk Baş");
        }
    }
}
