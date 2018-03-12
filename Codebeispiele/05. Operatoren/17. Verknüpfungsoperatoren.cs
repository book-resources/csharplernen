using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            bool c = true;
            bool d = false;

            Console.WriteLine(a && b); // a UND b
            Console.WriteLine(a && c); // a UND c
            Console.WriteLine(a || b); // a ODER b
            Console.WriteLine(b || d); // b ODER d
            Console.WriteLine(a ^ b); // a XOR b
            Console.WriteLine(a ^ c); // a XOR c
            Console.WriteLine(b ^ d); // b XOR d
            Console.WriteLine(!a); // Nicht a
            Console.WriteLine(!b); // Nicht b            
            Console.WriteLine(a && (c || d)); // Wir koennen auch mehr als zwei Operanden haben

            Console.ReadKey();
        }
    }
}