using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Guldkortet
{
    class KundRegister
    {
        // skapar enligt planerna KundRegister klassen
        public List<Kund> KundList = new List<Kund>(); // en lista som kommer från textfilen
        List<Kund> KundMedVinst = new List<Kund>(); // en lista med kunder som har vinster
        
        // skapar inläsning metod för klienter
        public void LoadKundList()
        {
            List<string> TempList = new List<string>(); // skapar temporär lista
            // kontrollerar att filen finns
            try   
            {
                using (StreamReader lasare = new StreamReader("kundlista.txt"))    // filen finns under bin/debug
                {
                    string rad = "";    // skapar en temporär sträng för en rad
                    while ((rad = lasare.ReadLine()) != null)   // så länge det finns något i filen att läsa
                    {
                        TempList.Add(rad);  // lägger rader som en element i listan
                    }
                }
            }
            catch(Exception err) { MessageBox.Show(err.Message, "inläsning"); return; }

            foreach (string a in TempList)  // läser in varje rad i temporära listan
            {
                string[] detaljKund = a.Split(new string[] { "###" }, StringSplitOptions.None);
                // vi bryter upp raden i olika sträng som läggs in i element
                // i detaljKund vektor och tar bort ### emellan dem
                // skapar ny Kund av varje rad utan ###
                Kund kund = new Kund(detaljKund[1], detaljKund[2], detaljKund[0]);
                KundList.Add(kund);    // vi lägger till raderna utan ### som ny Kund
            }
        }

        // skapar sök metoden för kunder
        public bool SearchKund(string _userdata)
        {
            bool hit = false;
            foreach (Kund v in KundList)
            {
                if(_userdata == v.Användardata)
                {
                    hit = true;
                    return hit;
                }
            }
            return hit;
        }
        // skapar sök metod för kunder med vinst
        public bool SearchKundVinst(string _userdata)
        {
            bool hit = false;
            foreach (Kund v in KundMedVinst)
            {
                if (_userdata == v.Användardata)
                {
                    hit = true;
                    return hit;
                }
            }
            return hit;
        }
    }
}
