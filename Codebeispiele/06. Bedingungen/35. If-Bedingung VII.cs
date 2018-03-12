using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int c = 20;
            int d = 5;
            if (a < c)
            {
                Console.WriteLine("a ist kleiner als c.");
                if (a < b)
                {
                    Console.WriteLine("a ist kleiner als b.");
                    if (d < c)
                    {
                        Console.WriteLine("d ist kleiner als c.");
                    }
                }
                else if (a > b)
                {
                    Console.WriteLine("a ist groesser als b.");
                    if (d < c)
                    {
                        Console.WriteLine("d ist kleiner als c.");
                    }
                }
                else
                {
                    Console.WriteLine("a und b sind gleich gross.");
                    if (d < c)
                    {
                        Console.WriteLine("d ist kleiner als c.");
                    }
                }
            }
            else if (a < d)
            {
                Console.WriteLine("a ist kleiner als d.");
            }
            else
            {
                Console.WriteLine("a nicht kleiner als b und d.");
            }
            Console.ReadKey();
        }
    }
}