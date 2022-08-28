using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CentralensTips
{
    public partial class Form1 : Form
    {
        Random slump = new Random();    // initierar en random
        Fillasare inLista = new Fillasare();    // skapar en tom lista
        string _titel, _skribent, _typ = ""; // skapar temporära variablar 
        DialogResult svar;  // temporär variabel
        int oldTemp = 0;    // variabel för att hålla koll på senaste slump för att undvika samma träff i rad

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)  // skapar en knapp för att avsluta appen
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)  // här kommer det mesta hända
        {   
            if (inLista.Listan.Count == 0 && File.Exists("tips_texter.txt")) // kontrollerar om listan och filen finns
            {
                inLista.Filladd();  // fyller listan med "böcker"
                int temp = slump.Next(1, inLista.Listan.Count); // laddar in slumpsiffran
                while(oldTemp == temp)  // så länge dem är lika så slumpar vi igen
                    temp = slump.Next(1, inLista.Listan.Count); // laddar in slumpsiffran igen
                textBox1.Text = inLista.Listan[temp].ToString(); //  slumpar fram en bok
                label1.ForeColor = (inLista.Listan[temp].Finnes == true) ? Color.Green : Color.Red; // starkare tips
                label1.Text = (inLista.Listan[temp].Finnes == true) ? "Tillgängligt" : "Utlånad";   // testar fram
                                                                                                    // en label text
                oldTemp = temp; // vi lagrar in senaste slumpsiffra
            }
            else if(inLista.Listan.Count > 0)   // när listan är inläst redan i minnet
            {
                int temp = slump.Next(1, inLista.Listan.Count); // laddar in slumpsiffran
                while (oldTemp == temp)  // så länge dem är lika så slumpar vi igen
                    temp = slump.Next(1, inLista.Listan.Count); // laddar in slumpsiffran igen
                textBox1.Text = inLista.Listan[temp].ToString(); //  slumpar fram en bok
                label1.ForeColor = (inLista.Listan[temp].Finnes == true) ? Color.Green : Color.Red; // starkare tips
                label1.Text = (inLista.Listan[temp].Finnes == true) ? "Tillgängligt" : "Utlånad";   // testar fram
                                                                                                    // en label text
                oldTemp = temp;
            }
            else
                MessageBox.Show("Filen \"tips_texter.txt\" saknas!");    // meddelande on filen saknas
        }

        private void button3_Click(object sender, EventArgs e)  //lägga till bok
        {
            if (File.Exists("tips_texter.txt")) // om filen finns
            {
                textBox1.Text = ""; // nollställer textboxen
                MessageBox.Show("Ange titel! Tryck klar när du är klar");   // visar en text box
                button1.Enabled = false;    // avaktiverar tips knappen för att undvika problem
                klar.Enabled = true;    // klar knappen aktiveras
                label1.Text = "Ange Titel!";    // hjälper med att veta vad som anges
                button3.Enabled = false;    // avaktiverar lägg till knappen för att undvika problem
            }
        }
        private void klar_Click(object sender, EventArgs e) // klar knappens inläggning av ny bok
        {
            if(label1.Text == "Ange Titel!")    // använder label text som indikator
            {
                _titel = textBox1.Text; // lagrar in titel
                MessageBox.Show("Ange Skribent! Tryck klar när du är klar");    // ber om att ange nästa variabel
                textBox1.Text = ""; // nollställer textboxen
                label1.Text = "Ange Skribent!"; // ändrar label som används som indikator
            }
            else if(label1.Text == "Ange Skribent!")    // för skribent
            {
                _skribent = textBox1.Text;  // lagrar in skribent
                MessageBox.Show("Ange Typ! Tryck klar när du är klar"); // ber om att ange nästa variabel
                textBox1.Text = ""; // nollställer textboxen
                label1.Text = "Ange Typ!";  // ändrar label som används som indikator
            }
            else if(label1.Text == "Ange Typ!") // för typ
            {
                if(textBox1.Text == "Roman")    // kontrollerar textboxen
                {
                    _typ = textBox1.Text;   // lagrar in den
                    // vi läser in med message box om boken finns i biblioteket
                    svar = MessageBox.Show("Välj om boken finns i biblioteket JA eller NEJ",
                        "BOK INSKRIVNING", MessageBoxButtons.YesNo);
                    textBox1.Text = ""; // nollställer textboxen
                    label1.Text = "Ange om boken finns!";   // ställer in label
                }
                else if (textBox1.Text == "Tidskrift")  // för tidskrift
                {
                    _typ = textBox1.Text;
                    // vi läser in med message box om boken finns i biblioteket
                    svar = MessageBox.Show("Välj om boken finns i biblioteket JA eller NEJ",
                        "BOK INSKRIVNING", MessageBoxButtons.YesNo);
                    textBox1.Text = "";
                    label1.Text = "Ange om boken finns!";
                }
                else if (textBox1.Text == "Novellsamling")  // för novellsamling
                {
                    _typ = textBox1.Text;
                    // vi läser in med message box om boken finns i biblioteket
                    svar = MessageBox.Show("Välj om boken finns i biblioteket JA eller NEJ", 
                        "BOK INSKRIVNING", MessageBoxButtons.YesNo);
                    textBox1.Text = "";
                    label1.Text = "Ange om boken finns!";
                }
                else
                {// för felaktiga svar på typ
                    MessageBox.Show("Ange korrekt Typ! - Roman - Tidskrift - Novellsamling - Tryck klar när du är klar");
                    textBox1.Text = ""; // nollställer textboxen igen
                }   
            }
            else if (label1.Text == "Ange om boken finns!") // för sista "Finnes" och själva inskrivning av nya boken
            {
                if(svar == DialogResult.Yes)    // vid klick på Yes
                {
                    inLista.Filtillag(_titel, _skribent, _typ, true);   // skapar och skriver in nya boken
                    textBox1.Text = ""; // nollställer textboxen
                    label1.Text = "Boken inlagd";   // ändrar label med meddelande att det är klart 
                    button1.Enabled = true;    // aktiverar tips knappen
                    klar.Enabled = false;   // avaktiverar inläggningar
                    button3.Enabled = true;    // aktiverar lägg till knappen nu är det klart
                }
                else if(svar == DialogResult.No)    // vid klick på No
                {
                    inLista.Filtillag(_titel, _skribent, _typ, false); // skapar och skriver in nya boken
                    textBox1.Text = ""; // nollställer textboxen
                    label1.Text = "Boken inlagd";
                    button1.Enabled = true;    // aktiverar tips knappen nu är det klart
                    klar.Enabled = false;   // avaktiverar inläggningar
                    button3.Enabled = true;    // aktiverar lägg till knappen nu är det klart
                }
            }
        }
    }
}
