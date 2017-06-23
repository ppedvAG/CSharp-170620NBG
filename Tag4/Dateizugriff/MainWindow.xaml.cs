using System;
using System.Collections.Generic;
using System.IO;
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

namespace Dateizugriff
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

        private void MenuItemÖffnen_Click(object sender, RoutedEventArgs e)
        {

            #region StreamReader
            //StreamReader sr = new StreamReader("demo.txt");
            //TextBoxInhalt.Text = sr.ReadToEnd();
            //sr.Close(); 
            #endregion

            TextBoxInhalt.Text = File.ReadAllText("demo.txt");

            MessageBox.Show("Datei wurde erfolgreich geöffnet !");
        }

        private void MenuItemSpeichern_Click(object sender, RoutedEventArgs e)
        {
            #region StreamWriter
            //StreamWriter sw = new StreamWriter("demo.txt");
            //sw.Write(TextBoxInhalt.Text);
            //sw.Flush();
            //sw.Close();
            #endregion  

            File.WriteAllText("demo.txt", TextBoxInhalt.Text);

            File.SetCreationTime("demo.txt", new DateTime(1821,6,23,12,30,53));

            MessageBox.Show("Datei wurde erfolgreich gespeichert !");
        }

        private void MenuItemBeenden_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItemHilfe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Das ist ein Texteditor, du solltest dich also auskennen ;) ");
        }
    }
}
