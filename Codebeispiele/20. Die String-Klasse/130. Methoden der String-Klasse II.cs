using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo";

            string vergleich = "Welt";
            Console.WriteLine(String.Compare(zeichenkette, vergleich));

            string vergleich2 = "Hallo";
            Console.WriteLine(String.Compare(zeichenkette, vergleich2));

            string vergleich3 = "Auto";
            Console.WriteLine(String.Compare(zeichenkette, vergleich3));

            Console.ReadKey();
        }
    }
}