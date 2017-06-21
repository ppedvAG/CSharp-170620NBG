using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Rechteck : Grafik
    {
        public int Höhe { get; set; }
        public int Breite { get; set; }

        // Verstecken
        public new void Zeichnen() // new - Schlüsselwort unterdrückt die Warnung in VS, Verstecken funktioniert auch ohne dem "new" !
        {
            //base.Zeichnen(); // ruft das Original aus der Basisklasse auf
            Console.WriteLine($"Ein Rechteck mit der Farbe {Farbe}, der Höhe {Höhe} und der Breite {Breite} wird gezeichnet");
        }
    }
}
