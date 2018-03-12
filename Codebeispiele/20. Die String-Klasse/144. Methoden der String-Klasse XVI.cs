using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";

            char[] charArray = zeichenkette.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            Console.ReadKey();
        }
    }
}