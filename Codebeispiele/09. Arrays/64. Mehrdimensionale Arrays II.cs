using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int[,] zahlen = new int[3, 4] {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
            };
            Console.WriteLine(zahlen[0, 3]);

            Console.ReadKey();
        }
    }
}