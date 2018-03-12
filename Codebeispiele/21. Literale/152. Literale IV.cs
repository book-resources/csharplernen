using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // "0xf" ist aequivalent zu "0Xf"
            int zahl = 0xf;
            Console.WriteLine(zahl);

            Console.ReadKey();
        }
    }
}