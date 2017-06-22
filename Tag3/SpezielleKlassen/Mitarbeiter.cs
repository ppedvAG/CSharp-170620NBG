using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpezielleKlassen
{
    class Mitarbeiter : Person
    {
        public int MitarbeiterID { get; set; }
        public string Abteilung { get; set; }

        public override void Geburtstag()
        {
            Alter++;
        }
    }
}
