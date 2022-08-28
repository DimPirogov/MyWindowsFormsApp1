using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_text
{
    public partial class Form2 : Form
    {
        TcpClient klient = new TcpClient();  // deklarerar klient och skapar ny client för anslutning
        int port = 12345;   // skapar port variabel
        public Form2()
        {
            InitializeComponent();
            klient.NoDelay = true;  // inställning för förseningar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!klient.Connected) StartaAnslutning();  // om det finns ingen koppling, start uppkoppling
        }

        public async void StartaAnslutning()
        {
            try
            {
                IPAddress address = IPAddress.Parse(textBox1.Text); // laddar in adressen från textboxen
                await klient.ConnectAsync(address, port);    // kopplar mot IP adressen + portnummer (.NET) metod
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartaSändning(textBox2.Text);
        }

        public async void StartaSändning( string message)
        {
            byte[] utData = Encoding.Unicode.GetBytes(message);   // vi packar meddelandet som bytes

            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);  // vi skickar message som är redan som bytes
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return ;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
