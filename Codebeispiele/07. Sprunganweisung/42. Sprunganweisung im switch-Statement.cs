using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int zahl = 2;
            switch (zahl)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    goto case 1;
            }
            Console.ReadKey();
        }
    }
}