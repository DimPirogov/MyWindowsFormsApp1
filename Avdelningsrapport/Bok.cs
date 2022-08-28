using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avdelningsrapport
{
    public class Bok    // skapar klassen bok
    {
        private string Titel;   // skapar egenskaperna motsvarande bilden i övningen
        private string Skribent; // i listan på bilden
        private string Typ;

        public Bok(string _titel, string _skribent, string _typ)    // vi skapar kontruktör
        {
            Titel = _titel; // tilldelar egenskaper
            Skribent = _skribent;
            Typ = _typ;
        }
        
        public override string ToString()   // skapar to-string metod
        {
            return "\"" + Titel + " \", en " + Typ + " av " + Skribent + ".";
        }
    }
}
