using System;
using System.IO;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            byte inhalt = 10;

            try
            {
                // Bis hier hat sich soweit nichts geaendert
                FileStream f = new FileStream("hallo.txt", FileMode.OpenOrCreate,
                                              FileAccess.ReadWrite, FileShare.None);

                // Den Bytewert reinschreiben, dieses Mal mit Schleife
                for (int i = 0; i < 10; i++)
                {
                    f.WriteByte(inhalt);
                }

                // Cursor an den Anfang (zum Lesen)
                f.Position = 0;

                // Inhalt lesen und auf der Konsole ausgeben
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(f.ReadByte());
                }

                // Schliessen des Streams nicht vergessen
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