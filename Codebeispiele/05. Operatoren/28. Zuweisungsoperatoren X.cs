using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 60; // Als Binaerzahl: 0011 1100
            int b = 10; // Als Binaerzahl: 0000 1010
            Console.WriteLine(a |= b); // Aequivalent zu: a = a | b;
            Console.ReadKey();
        }
    }
}