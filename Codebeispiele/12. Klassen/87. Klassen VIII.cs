using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // Der Zugriff auf eine statische Variable erfolgt direkt ueber die Klasse
            Console.WriteLine("Anzahl an Haustieren: {0}", Haustier.anzahlHaustiere);

            // Objekt mit parameterlosem Konstruktor erzeugen
            Haustier katze = new Haustier();

            // Objekt mit dem zweiten Konstruktor erzeugen
            Haustier hund = new Haustier("Bello", 2, "Hund");

            // Nun gibt es zwei Haustiere
            Console.WriteLine("Anzahl an Haustieren: {0}", Haustier.anzahlHaustiere);

            Console.WriteLine("Werte von katze: {0}, {1}, {2}", katze.name,
                              katze.alter, katze.tierart);
            Console.WriteLine("Werte von hund: {0}, {1}, {2}", hund.name, hund.alter,
                              hund.tierart);

            Console.ReadKey();
        }
    }

    public class Haustier
    {
        public static int anzahlHaustiere = 0;
        public string name;
        public int alter;
        public string tierart;

        // Parameterloser Konstruktor
        public Haustier()
        {
            Console.WriteLine("Es wurde ein neues Haustier-Objekt erstellt.");
            anzahlHaustiere++;
        }

        // Konstruktor mit Parametern
        public Haustier(string name_, int alter_, string tierart_)
        {
            name = name_;
            alter = alter_;
            tierart = tierart_;
            Console.WriteLine("Neues Objekt erstellt und Werte zugewiesen.");
            anzahlHaustiere++;
        }
    }
}