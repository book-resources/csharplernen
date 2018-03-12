using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";

            Console.WriteLine(zeichenkette.Substring(6));
            Console.WriteLine(zeichenkette.Substring(2));

            Console.ReadKey();
        }
    }
}