using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Hier ermitteln wir die Groesse und speichern 
            // sie in der Variablen groesse ab
            int groesse = sizeof(int);
            // Hier schreiben wir den Inhalt der Variablen groesse in die Konsole
            Console.WriteLine(groesse); 
            Console.ReadKey();
        }
    }
}