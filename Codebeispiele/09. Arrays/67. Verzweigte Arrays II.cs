using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int[][] zahlen = new int[5][];
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = new int[2];
            }

            Console.ReadKey();
        }
    }
}