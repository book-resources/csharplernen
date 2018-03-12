using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 60; // Als Binaerzahl: 0011 1100
            Console.WriteLine(a <<= 2); // Aequivalent zu: a = a << 2;
            Console.ReadKey();
        }
    }
}