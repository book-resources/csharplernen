using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            int zahl = 10;

            Console.WriteLine(Verringere(ref zahl));
            Console.WriteLine(zahl);

            Console.ReadKey();
        }

        static int Verringere(ref int zahl)
        {
            zahl = zahl - 1;
            return zahl;
        }
    }
}