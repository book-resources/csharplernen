using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";
            Console.WriteLine(zeichenkette.Contains("Hallo"));
            Console.WriteLine(zeichenkette.Contains("f"));

            Console.ReadKey();
        }
    }
}