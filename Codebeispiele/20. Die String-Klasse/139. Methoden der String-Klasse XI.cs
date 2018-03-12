using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";

            Console.WriteLine(zeichenkette.Remove(4, 5));
            Console.WriteLine(zeichenkette.Remove(5, 5));
            Console.WriteLine(zeichenkette.Remove(2, 2));

            Console.ReadKey();
        }
    }
}