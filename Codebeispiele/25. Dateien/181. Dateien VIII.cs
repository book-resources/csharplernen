using System;
using System.IO;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Verschiedene Werte, die wir in die Datei schreiben wollen
            char zeichen = 'a';
            bool wahr = true;
            int zahl = 100;

            try
            {
                using (StreamWriter writer = new StreamWriter("hallo.txt"))
                {
                    writer.WriteLine(zeichen);
                    writer.WriteLine(wahr);
                    writer.WriteLine(zahl);
                }

                // Nachdem wir geschrieben haben, lassen wir uns
                // den Inhalt der Datei auf der Konsole ausgeben
                using (StreamReader reader = new StreamReader("hallo.txt"))
                {
                    string inhalt = reader.ReadToEnd();
                    Console.WriteLine(inhalt);
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