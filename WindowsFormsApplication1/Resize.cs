using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arayuz
{
    public partial class Resize : Form
    {
        public Resize()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManuelResize.Form1 openResizeForm = new ManuelResize.Form1();
            openResizeForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayisalResize.Form1 openResizeForm2 = new SayisalResize.Form1();
            openResizeForm2.Show();
            Visible = false;
        }
    }
}
