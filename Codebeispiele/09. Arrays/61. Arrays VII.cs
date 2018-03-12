using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int[] zahlen = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }

            Console.ReadKey();
        }
    }
}