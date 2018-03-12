using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo";

            string klon = (string)zeichenkette.Clone();
            Console.WriteLine(klon);

            Console.ReadKey();
        }
    }
}