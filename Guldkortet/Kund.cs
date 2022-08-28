using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guldkortet
{   
    // skapar Kund klass
    class Kund
    {
        // den skapas enlig textfilen
        public string Name;
        public string Kommun;
        public string Användardata;
        List<Kort> UserList = new List<Kort>();    // här kommer alla eventuella vinster att läggas in

        // vi skapar en konstuktör med att lägga in vinst och utan vinst

        public Kund(string name, string kommun, string användardata)
        {
            Name = name;
            Kommun = kommun;
            Användardata = användardata;
        }

        // överlagrad metod för kund inklusibe vinst med själva kortet inkluderat
        public Kund(string name, string kommun, string användardata, List<Kort> userList)
        {
            Name = name;
            Kommun = kommun;
            Användardata = användardata;
            UserList = userList;
        }

        // skapar to string metod för kund för att läggas in i listboxen
        public override string ToString()
        {
            string kortLista = "";    // initierar en temporär variabel för att lagra utskrift av vinster
            if(UserList.Count > 0)
            {
                for (int i = 0; i < UserList.Count; i++)    // för varje vinst så utökas utskrift
                {
                    kortLista += UserList[i].ToString();    // en stäng som inkluderar alla kort som är vinster
                }
            }
            return Användardata + " " + Name + " " + Kommun + " " + kortLista;
        }

        // skapar inläggning av en vinst till kundens lista
        public void LaggTillVinst(Kort _kort)
        {
            UserList.Add(_kort);
        }


    }
}
