using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLektion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox1.Items.Count + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                listBox1.Items.Remove(listBox1.Items.Count);
            }
            else
            {
                label1.Text = "No Items do delete";
            }
        }
    }
}
