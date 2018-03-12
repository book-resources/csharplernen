using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            int groessereZahl = (a >= b) ? a : b;
            Console.WriteLine(groessereZahl);
            Console.ReadKey();
        }
    }
}