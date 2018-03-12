using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        struct Beispiel
        {
            public int a;
            public int b;
        }

        static void Main(string[] args)
        {
            Beispiel objekt = new Beispiel();

            // Wir koennen unsicheren Code auch durch Bloecke kennzeichnen
            unsafe
            {
                // Zeiger vom Datentyp Beispiel auf ein Element eben dieser Struktur
                Beispiel* zeiger = &objekt;

                /* Zugriff auf ein Member der Struktur. Dazu dereferenzieren wir zuerst
                 * und verwenden dann die normale Punktschreibweise, um mit den
                 * Variablen arbeiten zu koennen
                 */ 
                (*zeiger).a = 10;
                (*zeiger).b = 20;

                Console.WriteLine("a = {0}, b = {1}", (*zeiger).a, (*zeiger).b);
            }

            Console.ReadKey();
        }
    }
}