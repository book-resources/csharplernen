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

    }
}