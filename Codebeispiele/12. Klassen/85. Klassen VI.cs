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

    public class Mensch
    {
        // Membervariablen
        private int alter;
        private string name;
        private string vorname;

        // Konstruktor
        public Mensch(int alter, string name, string vorname)
        {
            this.alter = alter;
            this.name = name;
            this.vorname = vorname;
        }

        // Getter und Setter
        public int GetAlter()
        {
            // Hier spielt das this keine Rolle, da wir keine Parameter haben!
            return alter;
        }

        public void SetAlter(int alter)
        {
            this.alter = alter;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetVorname()
        {
            return vorname;
        }

        public void SetVorname(string vorname)
        {
            this.vorname = vorname;
        }
    }
}