using System;
using System.Windows.Forms;

namespace ErstesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Form unserFenster = new Fenster();
            Application.Run(unserFenster);
        }
    }
    class Fenster : Form
    {
        public Fenster()
        {
            // ...

            // Hinzufuegen des KeyEventHandler zum Ereignis KeyUp
            this.KeyUp += new KeyEventHandler(KeyEvent);
        }

        // Methode, die ausgefuehrt wird, sobald eine Taste losgelassen wird
        private static void KeyEvent(object sender, KeyEventArgs e)
        {
            // Pruefen, ob die Taste 'A' gedrueckt wurde
            if (e.KeyCode == Keys.A)
            {
                Console.WriteLine("Taste 'A' wurde gedrueckt.");
            }
            else
            {
                Console.WriteLine("Eine andere Taste wurde gedrueckt.");
            }
        }
    }
}