using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            HalloWelt klassenObjekt = new HalloWelt();
            Console.WriteLine(klassenObjekt.BerechneFakultaet(5));
            Console.ReadKey();
        }
        // Unsere rekursive Methode zur Berechnung der Fakultaet
        public int BerechneFakultaet(int zahl)
        {
            // Dies ist die Abbruchbedingung
            if (zahl == 0)
            {
                return 1;
            }
            // Hier findet der rekursive Aufruf statt
            else
            {
                return zahl * BerechneFakultaet(zahl - 1);
            }
        }
    }
}