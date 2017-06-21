using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlerbehandlung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }

            string eingabe = Console.ReadLine();

            try
            {
                int zahl = Convert.ToInt32(eingabe);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Bitte geben Sie nur Zahlen ein !");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Ihre Eingabe war zu groß oder zu klein!");
                Console.ReadKey();

                return; // Methode verlassen
                //Environment.Exit(0); // Applikation beenden - KEIN Finally-Block
            }
            finally // Wird immer ausgeführt, egal ob es eine Exception gibt oder nicht !
            {
                // z.B. DB-Verbindung beenden
                Console.WriteLine("----Ende---");
                Console.ReadKey();
            }


            // Übung: Benutzer gibt 2 Zahlen ein -> Addiert -> Summe wird ausgegeben
            #region Addierer

            ////1) Variablen deklarieren
            //int zahl1 = 0;
            //int zahl2 = 0;
            //int ergebnis = 0;

            //try
            //{
            //    Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            //    zahl1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            //    zahl2 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadKey();
            //    return; // Beenden, damit kein "Ergebnis" berechnet wird
            //}

            //ergebnis = zahl1 + zahl2;

            //Console.WriteLine($"Die Summe ist {ergebnis}");

            #endregion

            Console.ReadKey();
        }
    }
}
