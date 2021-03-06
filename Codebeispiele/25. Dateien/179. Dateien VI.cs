using System;
using System.IO;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Text, den wir in die Datei schreiben wollen
            string text = "Das hier soll in der Datei stehen.";

            try
            {
                StreamWriter writer = new StreamWriter("hallo.txt");
                writer.WriteLine(text);
                writer.Close();

                // Nachdem wir geschrieben haben, lassen wir uns
                // den Inhalt der Datei auf der Konsole ausgeben
                StreamReader reader = new StreamReader("hallo.txt");
                string inhalt = reader.ReadToEnd();
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