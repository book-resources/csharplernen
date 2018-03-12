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
                // Neues Objekt der Klasse erzeugen, der Parameter erwartet den Pfad
                DirectoryInfo pfad = new DirectoryInfo(@"C:\Users\Malte\Documents\Visual 
                Studio 2017\Projects\ErstesProjekt\ErstesProjekt\bin\Debug");

                // Wir koennen pruefen, ob ein Verzeichnis existiert
                // (das funktioniert auch mit Dateien!)
                if (pfad.Exists)
                {
                    Console.WriteLine("Der Pfad existiert!");
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