using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // Dem Array Werte zuweisen
            int[] zahlen = new int[10];
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = i;
            }
            // Das komplette Array ausgeben
            foreach (int j in zahlen)
            {
                Console.WriteLine(zahlen[j]);
            }
            Console.ReadKey();
        }
    }
}