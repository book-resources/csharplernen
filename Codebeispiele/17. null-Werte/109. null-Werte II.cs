using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            HalloWelt klassenObjekt = new HalloWelt();
            Console.WriteLine(klassenObjekt.Dividiere(10, 0));

            Console.ReadKey();
        }

        public double? Dividiere(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                return null;
            }
            else
            {
                return dividend / divisor;
            }
        }
    }
}