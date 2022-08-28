using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        int sum = 0;
        string currentNr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber(string number)
        {
            textBox1.Text += number;
            currentNr += number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           addNumber("1");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addNumber("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNumber("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addNumber("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addNumber("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addNumber("0");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(currentNr);
            textBox1.Text = sum + "+";
            currentNr = "";
        }
    }
}
