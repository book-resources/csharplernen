using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";
            string vergleich = "Hallo Welt";

            Console.WriteLine(zeichenkette.Equals(vergleich));
            Console.WriteLine(zeichenkette == vergleich);

            Console.ReadKey();
        }
    }
}