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

            // Zeichnet ein Rechteck
            e.Graphics.DrawRectangle(new Pen(Color.Red, 3), rechteck);

            /* Zeichnet eine Linie durch zwei Punkte, die Parameter sind dabei zunaechst 
             * ein Stift und dann die x-Koordinate und y-Koordinate vom ersten Punkt,
             * danach die x-Koordinate und y-Koordinate vom zweiten Punkt.
             * Es waere auch moeglich, nach dem Stift zwei Punkte zu uebergeben
             */
            e.Graphics.DrawLine(new Pen(Color.Blue, 3), 10, 10, 20, 20);

            /* Zeichnet eine Ellipse auf Basis eines Rechtecks
             * (fuer einen Kreis sind also Breite und Hoehe des Rechtecks gleich)
             */
            e.Graphics.DrawEllipse(new Pen(Color.Yellow, 3), rechteck);

            /* Zeichnet eine beliebge Figur aus den Punkten eines Arrays, welches nach
             * dem Stift als zweiter Parameter uebergeben wird (Array vom Typ Point),
             * indem die Punkte miteinander verbunden werden
             */
            e.Graphics.DrawPolygon(new Pen(Color.Green, 3), p);
        }
    }
}