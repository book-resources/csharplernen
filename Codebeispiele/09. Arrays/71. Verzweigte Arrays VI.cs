using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int[][] verzweigt = new int[][] {
                new int[3] {1, 2, 3},
                new int[5] {3, 3, 5, 23, 1},
                new int[2] {9,5}
            };
            for (int i = 0; i < verzweigt.Length; i++)
            {
                for (int j = 0; j < verzweigt[i].Length; j++)
                {
                    Console.WriteLine(verzweigt[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}