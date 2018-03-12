using System.Windows.Forms;
using System.Drawing;
using System;

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
        ComboBox unsereComboBox;

        public Fenster()
        {
            unsereComboBox = new ComboBox();
            unsereComboBox.BackColor = Color.Orange;
            unsereComboBox.ForeColor = Color.Black;
            unsereComboBox.AutoSize = true;
            unsereComboBox.Text = "Auswahl:";
            // So fuegen wir Auswahlmoeglichkeiten hinzu
            unsereComboBox.Items.Add("Auto");
            unsereComboBox.Items.Add("Bus");
            unsereComboBox.Items.Add("Bahn");
            unsereComboBox.Font = new Font("Arial", 12);
            unsereComboBox.Location = new Point(10, 10);
            unsereComboBox.SelectedIndexChanged += new EventHandler(StatusChanged);
            this.Controls.Add(unsereComboBox);
        }

        public void StatusChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Es wurde {0} ausgewaehlt.", unsereComboBox.SelectedItem);
        }
    }
}