using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            while (a < b)
            {
                a++; // Solange a kleiner als b ist, wird a um eins erhoeht
                Console.WriteLine(a); // Ausgabe in der Schleife
            }

            Console.ReadKey();
        }
    }
}