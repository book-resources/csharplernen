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
            this.Text = "Unser Fenster"; // Setzt den Fenstertitel
            this.Width = 600; // Setzt die Breite (in Pixel)
            this.Height = 400; // Setzt die Hoehe (in Pixel)
            // Gibt an, dass unser Fenster immer im Vordergrund sein soll
            this.TopMost = true;
            // Gibt an, dass das Fenster beim Programmstart mittig angezeigt wird
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}