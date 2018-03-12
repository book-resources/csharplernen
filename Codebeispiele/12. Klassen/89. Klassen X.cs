using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Haustier.GetAnzahlHaustiere());

            Console.ReadKey();
        }
    }

    public class Haustier
    {
        public static int anzahlHaustiere = 0;
        public string name;
        public int alter;
        public string tierart;

        // Eine statische Methode
        public static int GetAnzahlHaustiere()
        {
            return anzahlHaustiere;
        }
    }
}