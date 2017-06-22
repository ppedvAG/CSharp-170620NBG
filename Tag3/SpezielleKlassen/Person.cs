using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpezielleKlassen
{
    abstract class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }

        public abstract void Geburtstag();

        public static string NameAusgeben()
        {
            return $" ... ";
        }
    }
}
