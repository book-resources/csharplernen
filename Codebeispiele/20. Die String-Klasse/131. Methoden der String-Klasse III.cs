using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            object objekt1 = 100;
            object objekt2 = -123;
            Console.WriteLine(String.Concat(objekt1, objekt2));

            Console.ReadKey();
        }
    }
}