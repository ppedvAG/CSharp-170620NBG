using BankRottDLL;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankRottWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            int Kontonummer = 0;
            int Pin = 0;

            try
            {
                Kontonummer = Convert.ToInt32(TextBoxKontonummer.Text);
                Pin = Convert.ToInt32(PasswordBoxPin.Password);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie bei der Kontonummer und bei der Pin nur Zahlen ein !");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ihre Kontonummer oder Ihre Pin ist zu lang !");
                return;
            }


            Konto k;

            if(Banksystem.Login(Kontonummer,Pin,out k) == true)
            {
                // Login war erfolgreich
                Startseite s = new Startseite(k);
                s.Show(); // Startseite öffnen
                Close();  // Login-Fenster schließen
            }
            else
            {
                MessageBox.Show("Kontonummer oder PIN ungültig");
            }

        }
    }
}
