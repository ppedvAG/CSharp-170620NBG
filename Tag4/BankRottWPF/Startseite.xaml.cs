using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BankRottDLL;

namespace BankRottWPF
{
    /// <summary>
    /// Interaction logic for Startseite.xaml
    /// </summary>
    public partial class Startseite : Window
    {
        private Konto k;
        public Startseite(Konto k)
        {
            InitializeComponent();
            this.k = k;

            LabelBegrüßungstext.Content = $"Hallo {k.Inhaber}";
            LabelKontostand.Content = k.Kontostand;
        }

        private void ButtonAbheben_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal wert = Convert.ToDecimal(TextBoxBetrag.Text);
                k.Abheben(wert);

                TextBoxBetrag.Text = string.Empty; // = "";
                LabelKontostand.Content = k.Kontostand;
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie beim Betrag nur Zahlen ein");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ihr Betrag ist leider zu hoch");
            }
            catch (EingabeUngültigException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonEinzahlen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal wert = Convert.ToDecimal(TextBoxBetrag.Text);
                k.Einzahlen(wert);

                TextBoxBetrag.Text = string.Empty; // = "";
                LabelKontostand.Content = k.Kontostand;
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie beim Betrag nur Zahlen ein");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ihr Betrag ist leider zu hoch");
            }
            catch (EingabeUngültigException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
