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
            Console.WriteLine("Thread gestartet.");
            
            // Den Thread etwas arbeiten lassen, bevor wir ihn beenden
            Thread.Sleep(300);
            thread.Abort();

            // Danach pruefen wir, ob der Thread wirklich beendet wurde
            Thread.Sleep(100);
            if (!thread.IsAlive)
            {
                Console.WriteLine("Thread beendet.");
            }

            Console.ReadKey();
        }

        static void Methode()
        {
            /* Hier verwenden wir einen try...catch-Block, weil eine
             * ThreadAbortException auftreten kann
             */ 
            try
            {
                // In der Schleife warten wir jedes Mal 50 Millisekunden,
                // bevor wir mit dem naechsten Durchgang fortfahren
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("Thread arbeitet.");
                    Thread.Sleep(50);
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Exception!");
            }
        }
    }
}