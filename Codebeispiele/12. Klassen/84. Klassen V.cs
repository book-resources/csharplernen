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
        public Mensch(int alter_, string name_, string vorname_)
        {
            alter = alter_;
            name = name_;
            vorname = vorname_;
        }

        // Getter und Setter
        public int GetAlter()
        {
            return alter;
        }

        public void SetAlter(int alter_)
        {
            alter = alter_;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name_)
        {
            name = name_;
        }

        public string GetVorname()
        {
            return vorname;
        }

        public void SetVorname(string vorname_)
        {
            vorname = vorname_;
        }
    }
}