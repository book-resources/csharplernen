using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        delegate int Delegat(int zahl);

        static void Main(string[] args)
        {
            // Funktioniert wie eine anonyme Methode
            Delegat del = x => x * x;

            Console.WriteLine(del(10));

            Console.ReadKey();
        }
    }
}