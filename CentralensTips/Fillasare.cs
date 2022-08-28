using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralensTips
{
    public class Fillasare  // skapar inläsningsklass
    {
        public List<Bok> Listan = new List<Bok>();   // egenskap är en lista av böcker
        
        public void LaggTill(Bok bok)   // skapar inläggning av böcker
        {
            Listan.Add(bok);    // lägger till en bok i listan
        }

        public void Filladd()   // fil inläsning metod
        {
            List<string> bokLista = new List<string>(); // skapar temporär lista
            // startar en ström inläsning och släpper filen 
            using (StreamReader lasare = new StreamReader("tips_texter.txt"))  
            {
                string rad = "";    // skapar en temporär sträng för en rad
                while ((rad = lasare.ReadLine()) != null)   // så länge det finns något i filen att läsa
                {
                    bokLista.Add(rad);  // lägger rader som en element i listan
                }
            }
            
            foreach (string a in bokLista)  // läser in varje rad i listan
            {
                string[] detaljBok = a.Split(new string[] { "###" }, StringSplitOptions.None);
                // vi bryter upp raden i olika sträng som läggs in i element
                // i detaljBok vektor och tar bort ### emellan dem

                if (detaljBok[2] == "Roman")    // kollar upp typ av bok
                {
                    bool finnes = Convert.ToBoolean(detaljBok[3]);  // skapar en bool
                    Roman nyRoman = new Roman(detaljBok[0], detaljBok[1], finnes);  // skapar ny Roman
                    LaggTill(nyRoman);  // lägger boken in i listan
                }
                else if (detaljBok[2] == "Novellsamling")
                {
                    bool finnes = Convert.ToBoolean(detaljBok[3]);  // skapar en bool
                    Novellsamling nyNovellsamling = new Novellsamling(detaljBok[0], detaljBok[1], finnes); // skapar ny Novell
                    LaggTill(nyNovellsamling);  // lägger till
                }
                else if (detaljBok[2] == "Tidskrift")
                {
                    bool finnes = Convert.ToBoolean(detaljBok[3]);  // skapar en bool
                    Tidskrift nyTidskrift = new Tidskrift(detaljBok[0], detaljBok[1], finnes);  // skapar ny Tidskrift
                    LaggTill(nyTidskrift);  // lägger till
                }
            }
        }

        public void Filtillag(string titel, string skribent, string typ, bool finnes)   // metod för att lägga nya böcker
        {
            using (StreamWriter skrivare = new StreamWriter("tips_texter.txt", true)) // öppnar ström
                        // och tar och släpper filen med andra argumentet så läggs till text och skrivs inte över
            {
                skrivare.WriteLine(titel + "###" + skribent + "###" + typ + "###" + finnes);    //skriver en rad
            }
        }

    }
}
