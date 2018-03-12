using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";
            string kopie = String.Copy(zeichenkette);
            Console.WriteLine(kopie);

            Console.ReadKey();
        }
    }
}