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
                // Neues Objekt der Klasse erzeugen (der Pfad existiert noch nicht)
                DirectoryInfo pfad = new DirectoryInfo(@"C:\Users\Malte\Documents\Visual 
                Studio 2017\Projects\ErstesProjekt\ErstesProjekt\bin\Debug\NeuerPfad");

                // Wenn der Pfad existiert, schreiben es wir einfach in die Konsole
                if (pfad.Exists)
                {
                    Console.WriteLine("Der Pfad existiert!");
                }
                // Wenn der Pfad nicht existiert, erstellen wir ihn
                else
                {
                    pfad.Create();
                    Console.WriteLine("Der Pfad wurde erfolgreich erstellt.");
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