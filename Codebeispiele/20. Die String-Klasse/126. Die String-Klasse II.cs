using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            char[] zeichen = { 'S', 't', 'r', 'i', 'n', 'g' };

            string zeichenkette = new string(zeichen);
            Console.WriteLine(zeichenkette);

            Console.ReadKey();
        }
    }
}