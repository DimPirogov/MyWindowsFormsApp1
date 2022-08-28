using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Load(@"C:\Users\Dimitri\Pictures\Erice&Brynja.jpg");
            pictureBox1.Image = Image.FromFile(@"C:\Users\Dimitri\Pictures\Erice&Brynja.jpg");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            pictureBox1.Load("C:\\Users\\Dimitri\\Pictures\\Erice&Brynja2.jpg");
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Users\Dimitri\Pictures\Erice&Brynja3.jpg");
        }
    }
}
