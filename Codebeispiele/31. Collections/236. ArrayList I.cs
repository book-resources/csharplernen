using System;
using System.Collections;

namespace ErstesProjekt
{

    class Mainklasse
    {
        static void Main(string[] args)
        {
            // So initialisieren wir eine neue ArrayList
            ArrayList unsereArrayList = new ArrayList();

            // Werte hinzufuegen koennen wir so:
            unsereArrayList.Add(44);
            unsereArrayList.Add(65);

            // Ausgeben koennen wir den Inhalt mit einer foreach-Schleife
            foreach (int zahl in unsereArrayList)
            {
                Console.WriteLine(zahl);
            }

            Console.ReadKey();
        }
    }
}