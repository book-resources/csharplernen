using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            Ausgeben(50);
            Ausgeben("Hallo");
            Ausgeben('c');
            Ausgeben(true);

            Console.ReadKey();
        }

        static void Ausgeben<T>(T wert)
        {
            Console.WriteLine(wert);
        }
    }
}