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
                FileInfo[] dateien = pfad.GetFiles();
                for (int i = 0; i < dateien.Length; i++)
                {
                    Console.WriteLine(dateien[i]);
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