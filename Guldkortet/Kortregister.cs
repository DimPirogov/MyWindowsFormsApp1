using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Guldkortet
{
    class Kortregister
    {
        public List<Kort> KortLista = new List<Kort>();    // skapar en lista av kort med vinster

        public bool SearchKort(string _kort)    // vi kör sökning i kortlistan
        {
            bool hit = false;
            foreach (Kort v in KortLista)
            {
                if (_kort == v.Number)
                {
                    hit = true;
                    return hit;
                }
            }
            return hit;
        }

        // laddar in listan från filen
        public void LoadKortList()
        {
            List<string> tempKort = new List<string>(); // skapar temporär lista
            try
            {
                using (StreamReader lasare = new StreamReader("kortlista.txt"))    // filen finns under bin/debug
                {
                    string rad = "";    // skapar en temporär sträng för en rad
                    while ((rad = lasare.ReadLine()) != null)   // så länge det finns något i filen att läsa
                    {
                        tempKort.Add(rad);  // lägger rader som en element i listan
                    }
                }
            }
            catch(Exception err) { MessageBox.Show(err.Message, "inläsning"); return; }
                
            foreach (string a in tempKort)  // läser in varje rad i temporära listan
            {
                string[] delKort = a.Split(new string[] { "###" }, StringSplitOptions.None);
                // vi bryter upp raden i olika sträng som läggs in i element
                // i detaljKund vektor och tar bort ### emellan dem
                // skapar ny Kund av varje rad utan ###
                Kort kort = new Kort(delKort[0], delKort[1]);
                KortLista.Add(kort);    // vi lägger till raderna utan ### som ny kort i listan
            }
        }

    }
}
