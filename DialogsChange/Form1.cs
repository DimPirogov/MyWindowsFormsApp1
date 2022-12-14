using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogsChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = colorDialog1.ShowDialog();
            if(r == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = folderBrowserDialog1.ShowDialog();
            if(r == DialogResult.OK)
            {
                button2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = fontDialog1.ShowDialog();
            if( r == DialogResult.OK)
            {
                button3.Font = fontDialog1.Font;
            }
        }

        private void väljFärgToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult r = colorDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void väljMappToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = fontDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                button3.Font = fontDialog1.Font;
            }
        }

        private void väljTeckensnittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = fontDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                button3.Font = fontDialog1.Font;
            }
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }
    }
}
