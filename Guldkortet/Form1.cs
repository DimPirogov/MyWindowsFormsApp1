using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guldkortet
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;   // deklarerar lyssnare
        TcpClient klient; // deklarerar klient
        int port = 12345;   // initierar portnummer
        KundRegister _kundRegister = new KundRegister();    // vi startar kundregister
        Kortregister _kortRegister = new Kortregister();    // vi startar kortregister
        Kund nyKund;    // skapar temporär kund
        string incomData = "";  // temporär sträng för att arbeta med

        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonKopplaUpp_Click(object sender, EventArgs e)  
        {
            // kontrollerar att listorna är laddade
            if (_kundRegister.KundList.Count > 0 && _kortRegister.KortLista.Count > 0)
            {
                try
                {
                    lyssnare = new TcpListener(IPAddress.Any, port);   // anger "vart" den ska lyssna
                    lyssnare.Start();   // börjar lyssna
                }
                catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

                buttonKopplaUpp.BackColor = Color.Green;    // vi ändrar färg på knappen
                StartaMottagning(); // kopplar och tar emot mottagning
            }
            else
                MessageBox.Show("Alla listor är inte laddade, var god och ladda listorna", "Inläsning");
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
                MessageBox.Show(error.Message, Text);   // vi får feedback på fel
                return;
            }
            StartaLasning(klient);
            
        }

        public async void StartaLasning(TcpClient k)
        {
            byte[] inData = new byte[1024];  // reserverar storlek på strängen?
            // väntar på send i klienten:
            int antalByte = 0;
            try
            {
                antalByte = await k.GetStream().ReadAsync(inData, 0, inData.Length);  // .Net metod för await
                                                                                      // lagrar in strömmen som bytes?
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }

            incomData = Encoding.Unicode.GetString(inData, 0, antalByte);  // omvandlar "bytes" och lagrar in i variabeln
            string[] data = incomData.Split(new string[] { "-" }, StringSplitOptions.None);
            bool kontrollKund = _kundRegister.SearchKund(data[0]); // kontrollerar om kunden finns
            bool kontrollKort = _kortRegister.SearchKort(data[1]);  // kontrollerar om kortet finns i vinstlistan
            string kundNrNamnKommun = "";   // 2 temporära variabler
            string kortNrVinst = "";

            if (kontrollKund && kontrollKort)    // om båda delen är rätta då tar vi fram uppgifterna och skriver in dem  listboxen
            {
                foreach (Kund _kund in _kundRegister.KundList)  // vi går igenom kundlistan
                {
                    if (data[0] == _kund.Användardata)
                    {
                        kundNrNamnKommun = _kund.ToString();    // vi sparar kundens data i strängen
                    }
                }
                foreach (Kort _kort in _kortRegister.KortLista) // vi går igenom kortlistan
                {
                    if (data[1] == _kort.Number)
                    {
                        kortNrVinst = _kort.ToString();    // vi sparar kortsdata i strängen
                    }
                }
                // här är meningen att det ska läggas in en ny kund i en vinnare lista
                
                listBox.Items.Add(kundNrNamnKommun + kortNrVinst);  // vi skriver in vinnaren plus vinstnummer
            }

            StartaLasning(k);   // rekursivt
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // vi läser in och laddar in listan i arbetsminnet men kontrollerar innan att listorna finns och att listorna är tomma
            if (File.Exists("kundlista.txt") && _kundRegister.KundList.Count == 0)
             _kundRegister.LoadKundList();
            else
                MessageBox.Show("fil \"kundlista.txt\" saknas", "inläsning");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // läser in kortlistan och kontrollerar att den är inte redan laddad
            if (File.Exists("kortlista.txt") && _kortRegister.KortLista.Count == 0)
                _kortRegister.LoadKortList();
            else
                MessageBox.Show("fil \"kortlista.txt\" saknas", "inläsning");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   // avsluta programmet
        }
    }
}
