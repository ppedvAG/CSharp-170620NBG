using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKlickMich_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxEingabe.Text);
            //listBoxDaten.Items.Add(textBoxEingabe.Text);
            //textBoxEingabe.Text = "";

            listBoxDaten.DataSource = new string[] { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
        }
    }
}
