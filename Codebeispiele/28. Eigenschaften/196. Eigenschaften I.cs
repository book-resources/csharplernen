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

    public class Kreis
    {
        private int durchmesser;

        public int Durchmesser
        {
            get
            {
                return durchmesser;
            }
            set
            {
                durchmesser = value;
            }
        }
    }
}