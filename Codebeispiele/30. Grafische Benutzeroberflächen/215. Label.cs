using System.Windows.Forms;
using System.Drawing;

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
            Label unserLabel = new Label();
            unserLabel.Text = "Hier steht der Text.";
            unserLabel.Location = new Point(10, 100);
            unserLabel.ForeColor = Color.Black;
            // Schriftart und Schriftgroesse einstellen
            unserLabel.Font = new Font("Arial", 12);
            // Passt die Groesse automatisch an
            // (sonst wuerde der Text evtl. abgeschnitten werden)
            unserLabel.AutoSize = true;
            // Zum Fenster hinzufuegen
            this.Controls.Add(unserLabel);
        }
    }
}