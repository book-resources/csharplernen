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
            TextBox unsereTextBox = new TextBox();
            unsereTextBox.Text = "Vordefinierter Text";
            unsereTextBox.Location = new Point(10, 10);
            unsereTextBox.ForeColor = Color.Blue;
            unsereTextBox.AutoSize = true;
            this.Controls.Add(unsereTextBox);
        }
    }
}