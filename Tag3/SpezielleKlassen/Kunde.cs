using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpezielleKlassen
{
    class Kunde : Person
    {
        public int KundenID { get; set; }
        public bool Stammkunde { get; set; }

        public override void Geburtstag()
        {
            Alter++;
        }
    }
}
