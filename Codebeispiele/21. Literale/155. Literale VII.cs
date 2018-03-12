using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // "3.14E-2f" ist identisch zu "3.14e-2f"
            float zahl = 3.14E-2f;
            Console.WriteLine(zahl);

            Console.ReadKey();
        }
    }
}