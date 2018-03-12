using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(++a); // Praeinkrement
            Console.WriteLine(a);
            int b = 10;
            Console.WriteLine(b);
            Console.WriteLine(--b); //Praedekrement
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}