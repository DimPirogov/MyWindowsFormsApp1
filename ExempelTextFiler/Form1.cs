using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempelTextFiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dlgOppnaFil_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultat =  dlgOppnaFil.ShowDialog();
            if(resultat == DialogResult.OK)
            {
                MessageBox.Show(dlgOppnaFil.FileName);
                string anvMapp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments ); //ta reda på mina dok mapp
                MessageBox.Show(anvMapp);
                
            }
        }
    }
}
