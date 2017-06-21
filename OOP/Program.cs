using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fahrzeug
            //Fahrzeug Audi = new Fahrzeug();
            //Audi.Fahrer = "Max Mustermann";
            ////Audi.Geschwindigkeit = 200;
            //Audi.Kennzeichen = "ABC123";
            //Audi.Kilometerstand = 10000;

            //Fahrzeug VW = new Fahrzeug();
            //VW.Fahrer = "Tom Ate";
            ////VW.Geschwindigkeit = 100;
            //VW.Kennzeichen = "XYZ987";
            //VW.Kilometerstand = 50000;

            //Console.WriteLine(Audi.Kilometerstand);

            //Console.WriteLine(VW.Kilometerstand);
            //VW.KilometerstandErhöhen();
            //VW.KilometerstandErhöhen(50);
            //VW.KilometerstandErhöhen(25);
            //Console.WriteLine(VW.Kilometerstand);


            //VW.Geschwindigkeit = -1000;
            // Properties Variante Alt

            //Console.WriteLine(VW.GeschwindigkeitAuslesen());
            //VW.GeschwindigkeitSetzen(50);
            //Console.WriteLine(VW.GeschwindigkeitAuslesen());
            //VW.GeschwindigkeitSetzen(-500);
            //Console.WriteLine(VW.GeschwindigkeitAuslesen());


            //VW.Geschwindigkeit = 20;
            //VW.Geschwindigkeit = 500;

            //Console.WriteLine(VW.Geschwindigkeit);
            #endregion


            Taschenrechner t = new Taschenrechner();

            //int meineZahl = 10;
            //int ergebnis = t.Verdoppeln(ref meineZahl);

            //Console.WriteLine(ergebnis);
            //Console.WriteLine(meineZahl);

            // out - Parameter
            //string text = "12345";
            //int konvertierteZahl = 0;

            //if(Int32.TryParse(text, out konvertierteZahl) == true)
            //{
            //    // konvertierbar
            //}
            //else
            //{
            //    // keine gültige Int32-Zahl
            //}

            int[] meineZahlen = new int[3];

            meineZahlen[0] = 9;
            meineZahlen[1] = 7;
            meineZahlen[2] = 12;

            Console.WriteLine(meineZahlen[1]);

            // Array-Initialisierer
            //string[] wochentage = new string[] { "Montag", "Dienstag", "Mittwoch", "..." };
            // Kurzschreibweise
            string[] wochentage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag","Samstag","Sonntag" };

            //Console.WriteLine(wochentage[2]);

            foreach (string Tag in wochentage)
            {
                Console.WriteLine(Tag);
            }

            // Mehrdimensional
            // int[,] schachbrett = new int[8, 8];

            int ergebnis = t.Addieren(12,9,4,6,8);
            ergebnis = t.Addieren(9,9,9,9,9,9,9,9,9);

            Console.WriteLine("Die Summe aus {0} und {1} ist {2}", 33, 66, 99);

            Console.ReadKey();
        }
    }
}
