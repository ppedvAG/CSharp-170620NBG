using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Tom", "Ate");
            //p.Vorname = "Tom";
            //p.Nachname = "Ate";
            p.Alter = 20;
            p.Geburtstag(500);

            Person p2 = new Person();


            Mitarbeiter m1 = new Mitarbeiter();
            m1.Geburtstag(50000);

            Console.ReadKey();
        }
    }
}
