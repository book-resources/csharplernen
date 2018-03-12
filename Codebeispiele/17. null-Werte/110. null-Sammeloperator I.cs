using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = 100;
            Console.WriteLine(a ?? b);
            Console.ReadKey();
        }
    }
}