using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralensTips
{
    public class Roman : Bok
    {
        // skapar konstruktör för roman
        public Roman(string titel, string skribent, bool finnes)
        {
            Titel = titel;  // tilldelar respektive variabel till egenskap
            Skribent = skribent;
            Typ = "Roman";  // här hårdkodar vi att det är roman typ
            Finnes = finnes;
        }
    }
}
