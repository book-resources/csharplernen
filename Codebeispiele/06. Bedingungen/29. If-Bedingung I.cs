using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            if (a < b)
            {
                Console.WriteLine("a ist kleiner als b.");
            }
            else if (a <= b)
            {
                Console.WriteLine("a ist kleiner oder gleich b.");
            }  
            Console.ReadKey();
        }
    }
}