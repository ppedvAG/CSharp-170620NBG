using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Kreis : Grafik
    {
        public int Radius { get; set; }

        // Überschreiben
        public override void Zeichnen() // override sealed -> Verhindert das Überschreiben für Subklassen
        {
            //base.Zeichnen(); // ruft das Original aus der Basisklasse auf
            Console.WriteLine($"Ein Kreis mit der Farbe {Farbe} und dem Radius {Radius} wird gezeichnet");
        }
    }
}
