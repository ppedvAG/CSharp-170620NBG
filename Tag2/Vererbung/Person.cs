using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        private byte alter;
        public byte Alter
        {
            get { return alter; }
            set
            {
                if (value > alter)
                    alter = value;
                else
                    throw new Exception("Das Alter darf nur erhöht werden !");
            }
        }

        public decimal Kontostand { get; protected set; }

        public void Geburtstag()
        {
            Alter++;
        }
        public void Geburtstag(decimal Geld)
        {
            Alter++;
            Kontostand += Geld;
        }

        // Konstruktor
        public Person()
        {
            this.Vorname = "Max";
            this.Nachname = "Mustermann";
            Alter = 18;
            Kontostand = 1000;
        }

        /// <summary>
        /// Dieser Konstruktor erstellt eine Person mit den angegebenen Daten
        /// </summary>
        /// <param name="Vorname">Vorname der Person</param>
        /// <param name="Nachname">Nachname der Person</param>
        public Person(string Vorname, string Nachname)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            Alter = 18;
            Kontostand = 1000;
        }

        // Destruktor
        ~Person()
        {
            Console.WriteLine("Person wird gelöscht...");
        }

    }
}
