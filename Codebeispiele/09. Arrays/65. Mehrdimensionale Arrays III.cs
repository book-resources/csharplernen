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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(zahlen[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}