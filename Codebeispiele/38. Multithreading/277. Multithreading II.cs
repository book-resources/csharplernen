using System;
using System.Threading;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Methode);
            Thread thread = new Thread(threadStart);

            thread.Start();

            Console.ReadKey();
        }

        static void Methode()
        {
            Console.WriteLine("Diese Methode wird vom Thread ausgeführt.");

            // Die Dauer der Pause wird in Millisekunden angegeben
            Thread.Sleep(5000);

            Console.WriteLine("Pause zu Ende.");
        }
    }
}