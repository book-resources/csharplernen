using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (a < 5)
            {             
                if (a == 3)
                {
                    Console.WriteLine("Schleife beendet.");
                    break;
                }
                a++;
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}