using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 5;
            do
            {
                a++;
            }
            while (a < 5);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}