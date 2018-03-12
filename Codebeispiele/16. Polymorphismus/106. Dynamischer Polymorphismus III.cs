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
        // Die Methode Zeichnen ist hier nicht definiert
    }

    class Basisklasse : BasisklasseDerBasisklasse
    {
        // Hier ist die Methode Zeichnen auch nicht definiert
    }

    class BasisklasseDerBasisklasse
    {
        // Hier definieren wir die Methode Zeichnen
        public void Zeichnen()
        {
            Console.WriteLine("Zeichnen in der Basisklasse der Basisklasse");
        }
    }
}