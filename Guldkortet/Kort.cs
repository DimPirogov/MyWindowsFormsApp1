using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guldkortet
{
    // skapar enkel klass Kort med sitt eget nummer
    class Kort
    {
        public string Number;
        string Vinst;

        // skapar konstruktör med 2 egenskaper enligt textfilen
        public Kort(string number, string vinst)
        {
            Number = number;
            Vinst = vinst;
        }

        // skapar to-string metod för att skriva in i listboxen
        public override string ToString()
        {
            return " " + Number + " " + Vinst + " ";    
        }
    }
}
