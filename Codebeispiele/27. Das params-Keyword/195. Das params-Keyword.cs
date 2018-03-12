using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Wir koennen beliebig viele Parameter uebergeben
            Console.WriteLine(Addiere(50, 60, 70));
            Console.WriteLine(Addiere(50, 60, 70, 80, 90));
            Console.WriteLine(Addiere());

            Console.ReadKey();
        }

        static int Addiere(params int[] zahlen)
        {
            int ergebnis = 0;
            foreach (int zahl in zahlen)
            {
                ergebnis += zahl;
            }

            return ergebnis;
        }
    }
}