using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        enum Werte { einfacherWert = 10, doppelterWert = 20, dreifacherWert = 30, 
                     nochEinWert = 55 };

        static void Main(string[] args)
        {
            Console.WriteLine((byte)Werte.einfacherWert);

            Console.ReadKey();
        }
    }
}