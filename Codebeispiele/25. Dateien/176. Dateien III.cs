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
                StreamReader reader = new StreamReader("hallo.txt");

                // Inhalt der gesamten Datei lesen
                string inhalt = reader.ReadToEnd();

                // StreamReader beenden
                reader.Close();

                Console.WriteLine(inhalt);
            }
            catch (Exception e)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
            }

            Console.ReadKey();
        }
    }
}