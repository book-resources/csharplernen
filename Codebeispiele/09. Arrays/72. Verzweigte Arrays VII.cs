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
            foreach (int[] i in verzweigt)
            {
                foreach (int j in i)
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadKey();
        }
    }
}