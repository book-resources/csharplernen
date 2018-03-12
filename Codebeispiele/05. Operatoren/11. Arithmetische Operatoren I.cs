using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            // Addition
            Console.WriteLine("a + b = {0}", a + b);
            // Subtraktion
            Console.WriteLine("a - b = {0}", a - b);
            // Multiplikation
            Console.WriteLine("a * b = {0}", a * b);
            // Division
            Console.WriteLine("b / a = {0}", b / a);
            // Auch beim Programmieren gilt: Punkt- vor Strichrechnung!
            Console.WriteLine("a + b * 2 = {0}", a + b * 2);
            // Der Modulo-Operator gibt den Rest der Division an (20 / 10 = 2 Rest 0)
            Console.WriteLine("b % a = {0}", b % a);
            // Das Ergebnis dieser Rechnung ist 2, da 20 / 3 = 6 Rest 2
            Console.WriteLine("b % 3 = {0}", b % 3);
            Console.ReadKey();
        }
    }
}