using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";

            Console.WriteLine(zeichenkette.IndexOf("l"));
            Console.WriteLine(zeichenkette.LastIndexOf("l"));

            Console.ReadKey();
        }
    }
}