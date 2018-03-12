using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            int[] zahlen = { 12, 23, 33, 54, 35 };

            unsafe
            {
                // Einen Zeiger auf das Array 
                // (d.h. der Zeiger zeigt auf die Speicheradresse vom Anfang des Arrays)
                fixed (int* zeiger = zahlen)
                {
                    // Nun koennen wir das Array normal durchlaufen
                    for (int i = 0; i < zahlen.Length; i++)
                    {
                        Console.WriteLine("zahlen[" + i + "] = " + *(zeiger + i));
                        Console.WriteLine("Speicheradresse: " + i + (int)(zeiger + i));
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}