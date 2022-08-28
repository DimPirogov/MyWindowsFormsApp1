using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avdelningsrapport
{
    public class Filhantering  // skapar inläsningsklass
    {
        public List<Bok> bokListan = new List<Bok>();   // egenskap är en lista av böcker

        public void LaggTill(Bok bok)   // skapar inläggning av böcker
        {
            bokListan.Add(bok);    // lägger till en bok i listan
        }

        public void Filladd()   // fil inläsningsmetod
        {
            List<string> bokLista = new List<string>(); // skapar temporär lista
            // startar en ström inläsning och släpper filen 
            try
            {
                using (StreamReader lasare = new StreamReader("avd_texter.txt"))    // filen finns under bin/debug
                {
                    string rad = "";    // skapar en temporär sträng för en rad
                    while ((rad = lasare.ReadLine()) != null)   // så länge det finns något i filen att läsa
                    {
                        bokLista.Add(rad);  // lägger rader som en element i listan
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Text inläsning"); return;    // vid fel vi får detta meddelande
            }
            
            foreach (string a in bokLista)  // läser in varje rad i listan
            {
                string[] detaljBok = a.Split(new string[] { "###" }, StringSplitOptions.None);
                // vi bryter upp raden i olika sträng som läggs in i element
                // i detaljBok vektor och tar bort ### emellan dem

                Bok bok = new Bok(detaljBok[0], detaljBok[1], detaljBok[2]);    // skapar ny bok av varje rad utan ###
                bokListan.Add(bok);    // vi lägger till raderna utan ### som nya böcker
            }
        }

        public void Filtillag(string titel, string skribent, string typ, bool finnes)   // metod för att lägga nya böcker
        {
            try
            {   // öppnar ström och tar och släpper filen med andra argumentet så läggs till text och skrivs inte över
                using (StreamWriter skrivare = new StreamWriter("avd_texter.txt", true))
                {
                    skrivare.WriteLine(titel + "###" + skribent + "###" + typ + "###" + finnes);    //skriver en rad
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Text inskrivning"); return;    // vid fel vi får detta meddelande
            }
        }

    }
}
