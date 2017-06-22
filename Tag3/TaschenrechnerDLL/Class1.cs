using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerDLL
{
    public static class Taschenrechner
    {
        //public static int Addieren(int zahl1, int zahl2)
        //{
        //    return zahl1 + zahl2;
        //}
        public static int Addieren(int zahl1, int zahl2) =>  zahl1 + zahl2;
        public static int Subtrahieren(int zahl1, int zahl2) =>  zahl1 - zahl2;
        public static int Multiplizieren(int zahl1, int zahl2) =>  zahl1 * zahl2;
        public static int Dividieren(int zahl1, int zahl2) =>  zahl1 / zahl2;

    }
}
