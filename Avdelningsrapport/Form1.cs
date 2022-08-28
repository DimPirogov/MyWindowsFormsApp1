using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Avdelningsrapport
{
    public partial class Form1 : Form
    {
        TcpClient klient = new TcpClient(); // skapar ny klient för uppkopplingen
        int port = 12345; // initierar port varibel för uppkoppling
        Filhantering list = new Filhantering();    // skapar en tom lista
        
        public Form1()
        {
            InitializeComponent();
            klient.NoDelay = true;  // vi ställer in "förseningar" att all skickas på en gång
        }

        private void connect_Click(object sender, EventArgs e)  // vi kopplar upp oss mot servern
        {
            if (!klient.Connected) StartaAnslutning();  // om det finns ingen koppling, starta uppkoppling
        }

        
        public async void StartaAnslutning()    //  skapar en async uppkoppling
        {
            try
            {   // kör en try catch för eventuella fel vid uppkoppling
                IPAddress address = IPAddress.Parse("127.0.0.1"); // initierar adress variabel
                await klient.ConnectAsync(address, port);    // kopplar mot IP adressen + portnummer (.NET) metod
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;   // vi får info i messegeboxen
            }

            sendMarked.Enabled = true;  // vid aktiv uppkoppling vi aktiverar dessa knappar
            sendAll.Enabled = true;
            connect.BackColor = Color.Green;    // vid aktiv uppkoppling vi ändrar backgrundsfärg till grön
        }
        
        private void sendAll_Click(object sender, EventArgs e)  // skicka hela listan
        {
            if (listBox1.Items.Count > 0)   // kontrollerar att det finns något i listan
            {
                int i = 0;  // skapar en räknare
                foreach (Bok bok in list.bokListan)
                {
                    StartaSändning(listBox1.Items[i].ToString());   // vi skickar varje rad med to-string
                    i++;
                }
                //StartaSändning(listBox1.Items.ToString());  // vi skickar böcker med hjälp av to-string metod
                list.bokListan.Clear();     // raderar listan
                listBox1.Items.Clear();     // raderar listbox listan
            }
            else
                MessageBox.Show("Listan är tom", "Sändning");
            sendAll.Enabled = false;  // avaktiverar knappen
            sendMarked.Enabled = false; // avaktiverar knappen
        }

        private void sendMarked_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)   // kontrollerar att det finns något i listan
            {
                if (listBox1.SelectedItems.Count == 1)  // kontrollerar att en är markerad
                {
                    StartaSändning(listBox1.SelectedItem.ToString());   // vi skickar markerade rader/böcker
                    list.bokListan.RemoveAt(listBox1.SelectedIndex);    // tar bort markerad objekt i listan
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);    // tar bort samma element i själva listboxen
                }
                else
                    MessageBox.Show("Ingen bok är markerad", "Sändning");
            }
            else
            {
                MessageBox.Show("Listan är tom", "Sändning");
                sendAll.Enabled = false;  // avaktiverar knappen
                sendMarked.Enabled = false; // avaktiverar knappen
            }
                

        }

        public async void StartaSändning(string message)    // metod för att skicka strängar
        {
            byte[] utData = Encoding.Unicode.GetBytes(message);   // vi packar meddelandet som bytes

            try
            {   // vi packar in det i en try-catch sats för eventuella fel
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);  // vi skickar message som är redan som bytes
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }
        }


        private void loadList_Click(object sender, EventArgs e)
        {
            list.Filladd(); // laddar in listan med böcker
            foreach (Bok bok in list.bokListan)    // vi bläddrar igenom alla element i list.listan
            {
                listBox1.Items.Add(bok);    // lägger till böcker i listboxen med to-string metod
            }
            if(klient.Connected && listBox1.Items.Count > 0)    // om uppkopplingen är uppe och listan är inte tom
            {
                sendMarked.Enabled = true;  // vid aktiv uppkoppling vi aktiverar dessa knappar
                sendAll.Enabled = true;
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();   // avsluta knapp
        }
    }
}
