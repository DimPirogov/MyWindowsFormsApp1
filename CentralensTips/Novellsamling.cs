namespace CentralensTips
{
    public class Novellsamling : Bok  // skapar sista klassen
    {
        public Novellsamling(string titel, string skribent, bool finnes)
        {
            Titel = titel;  // tilldelar respektive variabel till egenskap
            Skribent = skribent;
            Typ = "Novellsamling";  // här hårdkodar typ
            Finnes = finnes;
        }
    }
}