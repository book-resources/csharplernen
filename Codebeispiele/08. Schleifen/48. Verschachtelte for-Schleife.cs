using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("i: {0}, j: {1}", i, j);
                }
            }

            Console.ReadKey();
        }
    }
}