using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Fahrzeug
    {
        // Felder:
        // public string Fahrer;
        public int Kilometerstand;
        // public string Kennzeichen;


        private int geschwindigkeit; // Privat -> Kleinschreibweise
        public int Geschwindigkeit // Property
        {
            get // Lesezugriff
            {
                return geschwindigkeit;
            }
            set // Schreibzugriff
            {
                if (value > 0 && value <= 300)
                    geschwindigkeit = value;
                else
                    Console.WriteLine("Ungültiger Wert für die Geschwindigkeit");
            }
        }

        // Property
        //propfull + TAB +TAB
        private string fahrer;
        public string Fahrer
        {
            get { return fahrer; }
            set { fahrer = value; }
        }

        // Autoproperty - Abkürzung, wenn get und set nicht verändert werden
        // prop + TAB +TAB
        public string Kennzeichen { get; set; }

        // Methoden:
        public void KilometerstandErhöhen()
        {
            Kilometerstand += 100;
        }
        public void KilometerstandErhöhen(int Wert)
        {
            Kilometerstand += Wert;
        }

        #region Properties "Variante Alt"

        //public int GeschwindigkeitAuslesen()
        //{
        //    return Geschwindigkeit;
        //}
        //public void GeschwindigkeitSetzen(int neueGeschwindigkeit)
        //{
        //    if(neueGeschwindigkeit > 0 && neueGeschwindigkeit <= 300)
        //        Geschwindigkeit = neueGeschwindigkeit;
        //    else
        //        Console.WriteLine("Ungültiger Wert für die Geschwindigkeit");
        //}
        #endregion


    }
}
