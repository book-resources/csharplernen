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

                // Inhalt der ersten Zeile lesen
                string ersteZeile = reader.ReadLine();
                // StreamReader beenden
                reader.Close();

                Console.WriteLine(ersteZeile);
            }
            catch (Exception e)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
            }

            Console.ReadKey();
        }
    }
}