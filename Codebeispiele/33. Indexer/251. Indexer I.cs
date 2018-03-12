using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }

    // Eine Klasse, die ein Buch (vereinfacht) repraesentiert
    public class Buch
    {
        // Wir haben zwei Eigenschaften, die beim Erzeugen eines
        // Objektes dieser Klasse gesetzt werden
        public string Titel { get; set; }
        public string Autor { get; set; }

        public Buch(string titel, string autor)
        {
            Titel = titel;
            Autor = autor;
        }
    }

    public class Buechersammlung
    {
        // Ein Array vom Datentyp Buch, in welchem wir Buecher abspeichern koennen
        private Buch[] buecher = new Buch[10];

        // Unser Indexer
        public Buch this[int index]
        {
            // Indexer haben ebenfalls get- und set-Accessoren,
            // wobei abhaengig von einem Index auf die Werte zugegriffen wird
            get
            {
                return buecher[index];
            }
            set
            {
                buecher[index] = value;
            }
        }
    }
}