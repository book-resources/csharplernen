using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";

            Console.WriteLine(zeichenkette.StartsWith("Hallo"));
            Console.WriteLine(zeichenkette.StartsWith("h"));
            Console.WriteLine(zeichenkette.StartsWith("H"));
            Console.WriteLine(zeichenkette.StartsWith("Hallo Welt"));

            Console.ReadKey();
        }
    }
}