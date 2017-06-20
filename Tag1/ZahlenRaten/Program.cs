using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahlenRaten
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Misc

            //Int16 zahl; // von -32768 bis +32767
            //zahl = Int16.MaxValue;
            //Console.WriteLine(zahl);
            //checked // Prüft auf Überlauf
            //{
            //    zahl += 1;
            //}
            //Console.WriteLine(zahl);

            ////---------
            //string text;

            //if (zahl > 50)
            //    text = "größer";
            //else
            //    text = "kleiner";

            //// tenäre Operator
            //string text2 = (zahl > 50) ? "größer" : "kleiner";
            ////-----------  bedingung    true       false


            //int z1 = 12;
            //int z2 = 12;
            //int z3;

            //if(z1 == z2) // Wertevergleich
            //    Console.WriteLine("gleich");

            //z3 = z2; // Wertekopie -> 12 wird kopiert und in z3 abgelegt
            //if(z1 == z3)
            //    Console.WriteLine("gleich");

            //// Referenztypen


            //object o = 12;
            //object o2 = 12;

            //if(o == o2) // Referenzvergleich
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("nicht gleich !");

            //if (o.Equals(o2)) // Der Wert dahinter wird verglichen
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("nicht gleich !");

            //object o3 = o; // Referenzkopie
            //if (o == o3) // Referenzvergleich nach Referenzkopie
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("nicht gleich !");

            //// Ausnahme: String -> Ist in wirklichkeit ein Referenztyp, verhält sich aber wie ein Wertetyp
            //string text = "abc";
            //string text2 = "abc";

            //if(text == text2)
            //    Console.WriteLine("gleicher string");

            #endregion


            /* Programm erstellt eine Zufallszahl (z.B. 0-100)
             * Benutzer gibt eine Zahl ein: z.B. 12
             * Ausgabe: "Größer" oder "Kleiner"
             */

            Random generator = new Random(); //Zufallszahlengenerator
            int zufallszahl = generator.Next(0, 100);


            do
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
                int eingabe = Convert.ToInt32(Console.ReadLine());

                if (zufallszahl > eingabe)
                {
                    Console.WriteLine("Zufallszahl ist größer");
                }
                else if (zufallszahl < eingabe)
                {
                    Console.WriteLine("Zufallszahl ist kleiner");
                }
                else
                {
                    Console.WriteLine("Zufallszahl erraten!");
                    break; // Schleife wird beendet
                } 
            } while (true); // == Endlosschleife

            Console.ReadKey();
        }
    }
}
