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
            Button unserButton = new Button();
            // Das kennen wir bereits alles
            unserButton.Text = "Drueck mich";
            unserButton.Location = new Point(10, 10);
            unserButton.ForeColor = Color.Blue;
            unserButton.AutoSize = true;
            this.Controls.Add(unserButton);
        }
    }
}