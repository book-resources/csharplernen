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

            Rectangle rechteck = new Rectangle(10, 10, 30, 30);
            Point[] p = { new Point(20, 50), new Point(10, 60), new Point(30, 60) };

            e.Graphics.FillRectangle(new SolidBrush(Color.Red), rechteck);

            e.Graphics.FillEllipse(Brushes.Yellow, rechteck);

            e.Graphics.FillPolygon(new SolidBrush(Color.Green), p);
        }
    }
}