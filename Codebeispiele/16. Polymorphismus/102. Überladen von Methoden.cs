using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        void Schreiben(int zahl)
        {
            Console.WriteLine(zahl);
        }

        void Schreiben(double zahl)
        {
            Console.WriteLine(zahl);
        }

        void Schreiben(string zeichenkette)
        {
            Console.WriteLine(zeichenkette);
        }

        static void Main(string[] args)
        {
            HalloWelt objekt = new HalloWelt();

            objekt.Schreiben(10);
            objekt.Schreiben(10.0);
            objekt.Schreiben("Hallo Welt!");

            Console.ReadKey();
        }
    }
}