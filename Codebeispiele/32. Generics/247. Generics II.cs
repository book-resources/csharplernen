using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            Box<int> zahlen = new Box<int>(5);

            zahlen.Add(57);
            zahlen.Add(43);
            Console.WriteLine(zahlen.Remove() + zahlen.Remove());

            Console.ReadKey();
        }
    }

    public class Box<T>
    {
        private readonly int groesse;
        private T[] elemente;
        private int zeiger = 0;

        public Box(int groesse)
        {
            this.groesse = groesse;
            elemente = new T[groesse];
        }

        public void Add(T value)
        {
            if (zeiger < groesse)
            {
                elemente[zeiger] = value;
                zeiger++;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public T Remove()
        {
            zeiger--;
            if (zeiger >= 0)
            {
                return elemente[zeiger];
            }
            else
            {
                zeiger = 0;
                throw new InvalidOperationException();
            }
        }
    }
}