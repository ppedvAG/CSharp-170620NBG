using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Mitarbeiter : Person // Erbt von der Klasse Person
    {
        public int MitarbeiterID { get; set; }
        public string Abteilung { get; set; }


        /* public       -> Zugriff von ausserhalb der Klasse möglich
         * private      -> Zugriff ist nur innerhalb der Klasse möglich
         * protected    -> Zugriff nur innerhalb der Klasse und abgeleiteten Klassen möglich
         * internal     -> Innerhalb einer Assembly public, ausserhalb: private
         * protected internal -> Mischung zwischen protected und internal
         * */
    }
}
