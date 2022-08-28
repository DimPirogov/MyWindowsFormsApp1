using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_text
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;   // deklarerar lyssnare
        TcpClient klient; // deklarerar klient
        int port = 12345;   // initierar portnummer

        public Form1()
        {
            InitializeComponent();
            Form2 form2 = new Form2();  // testar skapa ny form object
            form2.Show();   // testar att visa formen
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);   // anger "vart" den ska lyssna
                lyssnare.Start();   // börjar lyssna
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }
            
            button1.Enabled = false;    // avaktiverar button Starta server
            StartaMottagning(); // kopplar och tar emot mottagning
        }

        public async void StartaMottagning()
        {
            try
            {
                // väntar på Connect i klienten:
                klient = await lyssnare.AcceptTcpClientAsync(); // .Net metod för await
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
            StartaLasning(klient);
        }

        public async void StartaLasning( TcpClient k)
        {
            byte[] inData = new byte[1024];  // reserverar storlek på strängen?
            // väntar på send i klienten:
            int antalByte = 0;
            try
            {
                antalByte = await k.GetStream().ReadAsync(inData, 0, inData.Length);  // .Net metod för await
                                                    // lagrar in strömmen som bytes?
            }
            catch (Exception error){ MessageBox.Show(error.Message, Text); return;}

            textBox1.AppendText(Encoding.Unicode.GetString(inData, 0, antalByte) + "\r\n");  // omvandlar "bytes"
            StartaLasning(k);   // rekursivt
        }
    }
}
