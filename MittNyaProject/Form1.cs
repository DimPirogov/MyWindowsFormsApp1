using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MittNyaProject
{
    public partial class Form1 : Form
    {
        private List<string> sträng = new List<string>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = "initierad";
            sträng.Add("wohoo");
            listBox1.Items.Add(sträng[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            /*
            label1.Text = textBox1.Text;
            listBox1.Items.Add(textBox1.Text);
            MessageBox.Show(listBox1.Items.Count.ToString());
            */
        }
    }
}
