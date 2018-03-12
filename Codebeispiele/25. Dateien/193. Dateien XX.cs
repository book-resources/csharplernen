using System;
using System.IO;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            try
            {
                FileInfo file = new FileInfo(@"C:\Users\Malte\Documents\Visual Studio 
                2017\Projects\ErstesProjekt\ErstesProjekt\bin\Debug\hallo.txt");

                if (!file.Exists) file.Create();

                file.MoveTo(@"C:\Users\Malte\Documents\neuerName.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ein Fehler ist aufgetreten.");
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}