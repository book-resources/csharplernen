using System;

namespace ErstesProjekt
{
    class AbgeleiteteKlasse : Basisklasse
    {
        static void Main(string[] args)
        {
            AbgeleiteteKlasse abgeleitetesObjekt = new AbgeleiteteKlasse();
            abgeleitetesObjekt.Zeichnen();

            Console.ReadKey();
        }

        // Die Methode Zeichnen ist hier definiert
        public new void Zeichnen()
        {
            Console.WriteLine("Zeichnen in der abgeleiteten Klasse.");
        }

    }
    
    class Basisklasse
    {
        // Und hier ist die Methode Zeichnen ebenfalls definiert
        public void Zeichnen()
        {
            Console.WriteLine("Zeichnen in der Basisklasse.");
        }
    }
}