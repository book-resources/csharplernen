using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";
            Console.WriteLine(zeichenkette.Replace("Hallo", "Guten Tag,"));

            Console.ReadKey();
        }
    }
}