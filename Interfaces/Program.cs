using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objekt-Initialisierer
            // Obst o2 = new Obst() { Name = "Birne", Herkunft = "Tirol", Kcal = 80 };

            ObstHändler Max = new ObstHändler()
            {
                Produkt = new Obst() { Name = "Birne", Herkunft = "Tirol", Kcal = 80 },
                Anzahl = 500
            };

            ObstHändler Moritz = new ObstHändler()
            {
                Produkt = new Gemüse() { Name = "Paprika", Herkunft = "Ungarn", Geschmack="Mild" },
                Anzahl = 5000
            };

            ObstHändler Sophie = new ObstHändler()
            {
                Produkt = new Obst() { Name = "Orangen", Herkunft = "Spanien", Kcal = 150 },
                Anzahl = 100000
            };

            Console.ReadKey();
        }
    }
}
