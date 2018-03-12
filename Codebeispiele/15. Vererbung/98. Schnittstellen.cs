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

    interface MeinInterface
    {
        void ParameterloseMethode();
        bool MethodeMitParameter(int zahl);
    }
}