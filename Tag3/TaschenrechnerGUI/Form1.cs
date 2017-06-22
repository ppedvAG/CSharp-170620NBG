using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaschenrechnerDLL;

namespace TaschenrechnerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddieren_Click(object sender, EventArgs e)
        {
            int zahl1 = Convert.ToInt32(textBoxZahl1.Text);
            int zahl2 = Convert.ToInt32(textBoxZahl2.Text);

            int ergebnis = Taschenrechner.Addieren(zahl1, zahl2);

            textBoxErgebnis.Text = ergebnis.ToString();
        }

        private void buttonSubtrahieren_Click(object sender, EventArgs e)
        {
            textBoxErgebnis.Text = Taschenrechner.Subtrahieren(Convert.ToInt32(textBoxZahl1.Text), Convert.ToInt32(textBoxZahl2.Text)).ToString();
        }

        private void buttonMultiplizieren_Click(object sender, EventArgs e)
        {
            textBoxErgebnis.Text = Taschenrechner.Multiplizieren(Convert.ToInt32(textBoxZahl1.Text), Convert.ToInt32(textBoxZahl2.Text)).ToString();
        }

        private void buttonDividieren_Click(object sender, EventArgs e)
        {
            textBoxErgebnis.Text = Taschenrechner.Dividieren(Convert.ToInt32(textBoxZahl1.Text), Convert.ToInt32(textBoxZahl2.Text)).ToString();
        }
    }
}
