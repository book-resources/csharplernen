using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            HalloWelt klassenObjekt = new HalloWelt();
            klassenObjekt.IstGerade(10);
            Console.ReadKey();
        }

        public void IstGerade(int zahl)
        {
            if (zahl % 2 == 0)
            {
                Console.WriteLine("Die eingegebene Zahl ist gerade.");
            }
            else
            {
                Console.WriteLine("Die eingegebene Zahl ist ungerade.");
            }
        }
    }
}