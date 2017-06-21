using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Grafik
    {
        public string Farbe { get; set; }

        public virtual void Zeichnen() // virtual ermöglicht das Überschreiben der Methode
        {
            Console.WriteLine($"Eine Grafik mit der Farbe {Farbe} wird gezeichnet");
        }
    }
}
