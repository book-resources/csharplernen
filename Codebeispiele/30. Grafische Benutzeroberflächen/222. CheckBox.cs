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
        CheckBox unsereCheckBox;

        public Fenster()
        {
            unsereCheckBox = new CheckBox();
            unsereCheckBox.BackColor = Color.Orange;
            unsereCheckBox.AutoSize = true;
            // Zu Beginn nicht aktiviert
            unsereCheckBox.Checked = false;
            unsereCheckBox.Text = "Option 1";
            unsereCheckBox.Font = new Font("Arial", 12);
            unsereCheckBox.ForeColor = Color.Black;
            unsereCheckBox.Click += new EventHandler(StatusChanged);
            this.Controls.Add(unsereCheckBox);
        }

        public void StatusChanged(object sender, EventArgs e)
        {
            // Prueft, ob die CheckBox aktiviert ist
            if (unsereCheckBox.Checked)
            {
                Console.WriteLine("Checked!");
            }
        }
    }
}