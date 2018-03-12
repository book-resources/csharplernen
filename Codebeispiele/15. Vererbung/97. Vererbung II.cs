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

    public class Haustier
    {
        public static int anzahlHaustiere = 0;
        public string name;
        public int alter;
        public string tierart;

    }

    public interface Lebewesen
    {

    }

    class Hund : Haustier, Lebewesen
    {
       public Hund(string name_, int alter_)
        {
            name = name_;
            alter = alter_;
            tierart = "Hund";
            anzahlHaustiere++;
        }
    }
}