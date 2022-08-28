using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelExempel
{
    public partial class Form1 : Form
    {
        Excel.Application excel;
        Excel._Worksheet kalkylBlad;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excel = new Excel.Application();
            excel.Visible = true;

            excel.Workbooks.Add();
            kalkylBlad = excel.ActiveSheet;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Range cellA1 = kalkylBlad.Cells[1, "A"];
            dynamic värde = cellA1.Value;
            textBox1.AppendText( värde.ToString() );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kalkylBlad.SaveAs("Test.xlsx");
            excel.Quit();
        }
    }
}
