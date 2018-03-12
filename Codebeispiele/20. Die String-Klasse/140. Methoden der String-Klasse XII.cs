using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";

            Console.WriteLine(zeichenkette.Remove(3));
            Console.WriteLine(zeichenkette.Remove(5));

            Console.ReadKey();
        }
    }
}