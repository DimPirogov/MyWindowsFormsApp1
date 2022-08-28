using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralensTips
{
    public class Bok    // skapar klassen bok
    {
        public string Titel;   // skapar egenskaperna motsvarande text filen
        public string Skribent;
        public string Typ;
        public bool Finnes;
        public override string ToString()   // skapar to string metod
        {
            return "\"" + Titel + " \" av " + Skribent + ". " + "(" + Typ + ")" ;
        }
    }
}
