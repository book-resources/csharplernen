using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";
            Console.WriteLine(zeichenkette.EndsWith("Welt"));
            Console.WriteLine(zeichenkette.EndsWith("Hallo Welt"));

            Console.ReadKey();
        }
    }
}