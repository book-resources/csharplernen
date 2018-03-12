using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            bool c = true;
            bool d = false;
            // Identisch zu: if ((!d == true) && (a == b))
            if (!d && (a == b))
            {
                // Identisch zu: if ((d == true) || (!c == true))
                if (d || !c)
                {
                    Console.WriteLine("d oder nicht c ist wahr.");
                }
                else if (a < b)
                {
                    Console.WriteLine("a ist kleiner als b.");
                    // Identisch zu: if (c == true)
                    if (c)
                    {
                        Console.WriteLine("c ist wahr.");
                    }
                }
            }
            else if(a == b)
            {
                Console.WriteLine("a ist gleich b.");
                // Identisch zu: if ((a == b) && (c == true))
                if ((a == b) && c)
                {
                    Console.WriteLine("a ist gleich b und c ist wahr.");
                }
            }
            Console.ReadKey();
        }
    }
}