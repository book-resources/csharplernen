using System;
using System.Threading;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Der Parameter gibt an, was vom Thread ausgefuehrt werden soll
            ThreadStart threadStart = new ThreadStart(Methode);

            // Wir uebergeben den ThreadStart an einen Thread
            Thread thread = new Thread(threadStart);

            // Dieser Thread kann nun gestartet werden
            thread.Start();

            for (int i = 0; i <= 100; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    Console.Write(".");
                } 
                Console.WriteLine("Main " + i);
            }

            Console.ReadKey();
        }

        static void Methode()
        {
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine("Methode " + i);
            }
        }
    }
}