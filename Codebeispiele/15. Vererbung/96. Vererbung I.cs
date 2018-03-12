using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // Wir koennen ueber die Elternklasse auf die statische Variable zugreifen
            Console.WriteLine("Anzahl Haustiere: {0}", Haustier.anzahlHaustiere);

            // Oder aber ueber die Kindklasse
            Hund hund1 = new Hund("bello", 2);
            Console.WriteLine("Anzahl Haustiere: {0}", Hund.anzahlHaustiere);

            Console.WriteLine("Name von hund1: {0}", hund1.name);
            Console.WriteLine("Alter von hund1: {0}", hund1.alter);
            Console.WriteLine("Tierart von hund1: {0}", hund1.tierart);

            Console.ReadKey();
        }
    }

    public class Haustier
    {
        public static int anzahlHaustiere = 0;
        public string name;
        public int alter;
        public string tierart;

    }

    class Hund : Haustier
    {
        public Hund(string name_, int alter_)
        {
            name = name_;
            alter = alter_;
            tierart = "Hund";
            anzahlHaustiere++;
        }
    }
}