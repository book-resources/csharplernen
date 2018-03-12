using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;

            Console.WriteLine(a == b); // Wahr, wenn a gleich b
            Console.WriteLine(a != b); // Wahr, wenn a ungleich b
            Console.WriteLine(a > b); // Wahr, wenn a groesser b
            Console.WriteLine(a < b); // Wahr, wenn a kleiner b
            Console.WriteLine(a >= b); // Wahr, wenn a groesser oder gleich b
            Console.WriteLine(a <= b); // Wahr, wenn a kleiner oder gleich b

            Console.ReadKey();
        }
    }
}