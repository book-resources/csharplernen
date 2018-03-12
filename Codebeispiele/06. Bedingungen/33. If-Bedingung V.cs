using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            if (a < b)
            {
                Console.WriteLine("a ist kleiner als b.");
            }
            else if (a > b)
            {
                Console.WriteLine("a ist groesser als b.");
            }
            else
            {
                Console.WriteLine("a und b sind gleich gross.");
            }
            Console.ReadKey();
        }
    }
}