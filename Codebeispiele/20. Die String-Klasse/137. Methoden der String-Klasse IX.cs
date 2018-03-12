using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";

            Console.WriteLine(zeichenkette.Insert(10, "!!!"));

            Console.ReadKey();
        }
    }
}