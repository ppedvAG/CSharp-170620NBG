using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine Zahl ein: ");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            if(eingabe > 50)
            {
                Console.WriteLine($"{eingabe} ist größer als 50");
            }
            else if (eingabe == 50)
            {
                Console.WriteLine("Exakt 50 !");
            }
            else
            {
                Console.WriteLine($"{eingabe} ist kleiner als 50");
            }

            //if((zahl1 > 0) && (zahl1 < 100))

            switch (eingabe)
            {
                case (1):
                    Console.WriteLine("Exakt 1");
                    break;
                case (2):
                    Console.WriteLine("Exakt 2");
                    break;
                case (3):
                case (4):
                case (5):
                    Console.WriteLine("3,4 oder 5");
                    break;
                default:
                    Console.WriteLine("Etwas anderes ...");
                    break;
            }

            // Übung: 1 -> "Sehr gut", 2 -> "Gut"
            // Tipp: case("1") ....   default: cw("Ungültige Eingabe")

            Console.ReadKey();
        }
    }
}
