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

                // Das erste Zeichen der Datei als ASCII-Code
                int asciiZeichen = reader.Read();
                // StreamReader beenden
                reader.Close();

                Console.WriteLine(asciiZeichen);
            }
            catch (Exception e)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
            }

            Console.ReadKey();
        }
    }
}