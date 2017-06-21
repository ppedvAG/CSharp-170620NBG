using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Taschenrechner
    {
        // Übung: 4 Grundrechenarten einbauen
        public int Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        //Optionaler Parameter
        public int Dividieren(int zahl1, int zahl2 = 2)
        {
            return zahl1 / zahl2;
        }

        // Übergabe per Referenz
        public int Verdoppeln(ref int wert)
        {
            wert *= 2;
            return wert;
        }

        // params
        //public int Addieren(int zahl1, int zahl2, int zahl3)
        //{
        //    return zahl1 + zahl2 + zahl3;
        //}
        //public int Addieren(int zahl1, int zahl2, int zahl3, int zahl4)
        //{
        //    return zahl1 + zahl2 + zahl3 + zahl4;
        //}

        public int Addieren(params int[] zahlen)
        {
            return zahlen.Sum();
        }
    }
}
