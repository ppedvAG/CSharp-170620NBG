using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRottDLL
{
    public static class Banksystem
    {
        private static Dictionary<int, Konto> Kontodictionary;

        static Banksystem()
        {
            Kontodictionary = new Dictionary<int, Konto>();

            Kontodictionary.Add(1111, new Girokonto("Tom Ate", 1111, 1111, -5000, 200));
            Kontodictionary.Add(2222, new Girokonto("Anna Nass", 2222, 2222, -15000, 20000));
            Kontodictionary.Add(3333, new Jugendkonto("Peter Silie", 3333, 3333, 0));
            Kontodictionary.Add(4444, new Jugendkonto("Franz Ose", 4444, 4444, 15000));
            Kontodictionary.Add(5555, new Girokonto("Martha Pfahl", 5555, 5555, -100000, 10000000));
        }

        public static bool Login(int Kontonummer,int Pin,out Konto k) // Wenn der Login erfolgreich ist, wird das dazugehörige Konto ebenfalls zurückgegeben
        {
            if( (Kontodictionary.ContainsKey(Kontonummer) == false)
                || (Kontodictionary[Kontonummer].CheckPin(Pin) == false))
            {
                // Kontonummer ist nicht vorhanden -> abbrechen;
                // Oder: Pin war falsch
                k = null;
                return false;
            }

            // Kontonummer und PIN sind richtig
            k = Kontodictionary[Kontonummer];
            return true;
        }
    }
}
