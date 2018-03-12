using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            Mainklasse.InitZahl(out int zahl);

            Console.ReadKey();
        }

        static void InitZahl(out int zahl)
        {
            zahl = 100;
            Console.WriteLine(zahl);
        }
    }
}