using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        delegate int Delegat(int zahl);

        static void Main(string[] args)
        {
            // Eine aehnliche Darstellung
            Delegat del = delegate (int x) { return x = x * x; };

            Console.WriteLine(del(10));

            Console.ReadKey();
        }
    }
}