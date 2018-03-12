using System;
using System.Reflection;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            Klasse objekt = new Klasse();
            object[] parameter = new object[] { 10, 20 };

            Information(objekt, "Methode", parameter);
            Information(objekt, "Methode2", parameter);

            Console.ReadKey();
        }

        static void Information(object objekt, string name, object[] param)
        {
            MethodInfo methodenInfo = objekt.GetType().GetMethod(name);

            if (methodenInfo != null)
            {
                Console.WriteLine("Rückgabewert: " + methodenInfo.Invoke(objekt, param));
            }
        }
    }

    class Klasse
    {
        public static int Methode(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int Methode2(int a, int b)
        {
            return a < b ? a : b;
        }
    }
}