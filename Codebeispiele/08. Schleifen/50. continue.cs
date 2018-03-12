using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine("Durchgang Nummer {0}", i);
            }

            Console.ReadKey();
        }
    }
}