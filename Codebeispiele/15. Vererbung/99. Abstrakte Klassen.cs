using System;

namespace ErstesProjekt
{
    class HalloWelt : Abstrakt
    {
        static void Main(string[] args)
        {
            // Da wir alle Methoden erben, koennen wir die Methoden ueber unser Objekt                 
            // dieser Klasse aufrufen
            HalloWelt einObjekt = new HalloWelt();
            einObjekt.NormaleMethode();
            einObjekt.AbstrakteMethode();
           
            Console.ReadKey();
        }

        // Da diese Klasse von der abstrakten Klasse erbt, muessen wir alle abstrakten 
        // Methoden ueberschreiben, was mit dem Keyword override gemacht wird
        public override void AbstrakteMethode()
        {
            Console.WriteLine("Jetzt ist die Methode implementiert.");
        }
    }

    abstract class Abstrakt
    {
        // Hier muessen wir abstrakte Methoden mit dem Keyword abstract kennzeichnen
        public abstract void AbstrakteMethode();

        public void NormaleMethode()
        {
            Console.WriteLine("Hier darf bereits eine Implementierung sein.");
        }
    }
}