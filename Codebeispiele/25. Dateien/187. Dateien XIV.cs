using System;
using System.IO;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            try
            {
                // Neues Objekt der Klasse erzeugen 
                DirectoryInfo pfad = new DirectoryInfo(@"C:\Users\Malte\Documents\Visual 
                Studio 2017\Projects\ErstesProjekt\ErstesProjekt\bin\Debug");

                // Wir bekommen ein Array zurueck, das wir durchlaufen
                DirectoryInfo[] pfade = pfad.GetDirectories();
                for (int i = 0; i < pfade.Length; i++)
                {
                    Console.WriteLine(pfade[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
            }

            Console.ReadKey();
        }
    }
}