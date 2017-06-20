using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine Zahl ein: ");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            #region Zählergesteuerte Schleife
            ////eingabe = eingabe + 1;
            ////eingabe -= 2;
            ////eingabe++;
            ////eingabe--;

            //// Zählergesteuerte Schleife
            //for(int i = 1; i <= eingabe;i++)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            // Kopfgesteuert
            while(eingabe > 0)
            {
                Console.WriteLine(eingabe);
                eingabe--;
            }

            //Fußgesteuert
            do
            {
                Console.WriteLine(eingabe);
                eingabe++;
            } while (eingabe < 20);

            // Übung: Benutzer muss eine Zahl zwischen 0 und 100 eingeben.
            // Wenn ungültig -> neustart

            Console.ReadKey();
        }
    }
}
