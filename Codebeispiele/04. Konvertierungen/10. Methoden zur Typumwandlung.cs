using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int zahl = 10;

            // Konvertierung nach bool
            bool wahrheitswert = Convert.ToBoolean(zahl);

            // Konvertierung nach string
            string zeichenkette = Convert.ToString(zahl);

            // Ausgabe der Werte
            Console.WriteLine(wahrheitswert);
            Console.WriteLine(zeichenkette);

            Console.ReadKey();
        }
    }
}