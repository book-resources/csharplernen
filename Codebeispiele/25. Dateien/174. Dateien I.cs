using System;
using System.IO;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // Ein Bytewert, der in die Datei geschrieben werden kann
            byte inhalt = 10;
 
            try
            {
                // Einen neuen Filestream erzeugen, der eine Datei oeffnet oder erstellt.
                // Wir brauchen sowohl Lese- als auch Schreibzugrifff fuer dieses Beispiel
                FileStream f = new FileStream("hallo.txt", FileMode.OpenOrCreate,
                                          FileAccess.ReadWrite, FileShare.None);
                // Den Bytewert reinschreiben
                f.WriteByte(inhalt);
                // Den Cursor an den Anfang setzen, damit ab dort gelesen wird
                f.Position = 0;
                // Den Inhalt lesen und auf der Konsole ausgeben
                Console.Write(f.ReadByte());
                // Wichtig: Den FileStream wieder schliessen
                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten!");
            }

            Console.ReadKey();
        }
    }
}