using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralensTips
{
    public class Tidskrift : Bok    // skapar tidskrift
    {
        public Tidskrift(string titel, string skribent, bool finnes)
        {
            Titel = titel;  // tilldelar respektive variabel till egenskap
            Skribent = skribent;
            Typ = "Tidskrift";  // här hårdkodar typ
            Finnes = finnes;
        }
    }
}
