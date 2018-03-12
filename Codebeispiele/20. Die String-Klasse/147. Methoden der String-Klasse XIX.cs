using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "      Hallo Welt";

            Console.WriteLine(zeichenkette.Trim());
            Console.WriteLine(zeichenkette);

            Console.ReadKey();
        }
    }
}