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
            this.AutoSize = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen stift = new Pen(Color.Red, 3);

            // Erstellen eines neuen Rechtecks
            Rectangle rechteck = new Rectangle(0, 0, 10, 10);

            // Zeichnen des Rechtecks
            e.Graphics.DrawRectangle(stift, rechteck);
        }
    }
}