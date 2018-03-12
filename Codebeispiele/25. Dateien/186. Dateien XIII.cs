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

                // Erstellen eines Unterverzeichnisses
                pfad.CreateSubdirectory("Unterverzeichnis");
                Console.WriteLine("Das Unterverzeichnis wurde erstellt.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
            }

            Console.ReadKey();
        }
    }
}