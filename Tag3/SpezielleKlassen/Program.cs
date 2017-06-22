using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpezielleKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            Kunde k = new Kunde();
            Mitarbeiter m = new Mitarbeiter();

            int ergebnis = Taschenrechner.Addieren(12, 3);

            Console.WriteLine(ergebnis);

            AufgeteilteKlasse a = new AufgeteilteKlasse();

            Console.ReadKey();
        }
    }
}
