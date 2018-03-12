using System;
using System.Reflection;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            Klasse objekt = new Klasse();

            // Typinformationen bekommen
            Type typInfo = objekt.GetType();

            // Liefert ebenfalls den Typ der Klasse
            Console.WriteLine(typeof(Klasse));

            // Methodeninformationen ueber die Typinformation bekommen
            MethodInfo methodenInfo = typInfo.GetMethod("Methode");
            Console.WriteLine(methodenInfo);

            // Ausgabe des Rueckgabewertes, sofern die Methodeninfo existiert
            if (methodenInfo != null)
            {
                // Parameter, mit denen die Methode aufgerufen wird, 
                // um den Rueckgabewert zu bestimmen
                object[] param = new object[] { 10, 20 };
                Console.WriteLine("Rueckgabewert: " + methodenInfo.Invoke(objekt, param));
            }

            Console.ReadKey();
        }
    }

    class Klasse
    {
        // Methode, die die groessere Zahl von zwei Zahlen zurueckgibt
        public static int Methode(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}