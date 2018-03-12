using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // Objekt mit parameterlosem Konstruktor erzeugen
            Haustier katze = new Haustier();

            // Objekt mit dem zweiten Konstruktor erzeugen
            Haustier hund = new Haustier("Bello", 2, "Hund");

            Console.ReadKey();
        }
    }

    public class Haustier
    {
        public string name;
        public int alter;
        public string tierart;

        // Parameterloser Konstruktor
        public Haustier()
        {
            Console.WriteLine("Es wurde ein neues Haustier-Objekt erstellt.");
        }

        // Konstruktor mit Parametern
        public Haustier(string name_, int alter_, string tierart_)
        {
            name = name_;
            alter = alter_;
            tierart = tierart_;
            Console.WriteLine("Neues Objekt erstellt und Werte zugewiesen.");
        }
    }
}