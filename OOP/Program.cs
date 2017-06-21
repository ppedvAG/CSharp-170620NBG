using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug Audi = new Fahrzeug();
            Audi.Fahrer = "Max Mustermann";
            //Audi.Geschwindigkeit = 200;
            Audi.Kennzeichen = "ABC123";
            Audi.Kilometerstand = 10000;

            Fahrzeug VW = new Fahrzeug();
            VW.Fahrer = "Tom Ate";
            //VW.Geschwindigkeit = 100;
            VW.Kennzeichen = "XYZ987";
            VW.Kilometerstand = 50000;

            Console.WriteLine(Audi.Kilometerstand);

            Console.WriteLine(VW.Kilometerstand);
            VW.KilometerstandErhöhen();
            VW.KilometerstandErhöhen(50);
            VW.KilometerstandErhöhen(25);
            Console.WriteLine(VW.Kilometerstand);


            //VW.Geschwindigkeit = -1000;
            // Properties Variante Alt

            //Console.WriteLine(VW.GeschwindigkeitAuslesen());
            //VW.GeschwindigkeitSetzen(50);
            //Console.WriteLine(VW.GeschwindigkeitAuslesen());
            //VW.GeschwindigkeitSetzen(-500);
            //Console.WriteLine(VW.GeschwindigkeitAuslesen());


            VW.Geschwindigkeit = 20;
            VW.Geschwindigkeit = 500;

            Console.WriteLine(VW.Geschwindigkeit);


            Console.ReadKey();
        }
    }
}
