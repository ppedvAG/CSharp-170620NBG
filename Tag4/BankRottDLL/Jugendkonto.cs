using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRottDLL
{
    public class Jugendkonto : Konto
    {
        public Jugendkonto(string Inhaber, int Kontonummer, int Pin, decimal Kontostand = 0) : base(Inhaber, Kontonummer, Pin, Kontostand)
        {
        }

        public override void Abheben(decimal Wert)
        {
            if (Wert > 50)
                throw new EingabeUngültigException("Sie dürfen nicht mehr als 50€ auf einmal abheben !");

            if (Wert > 0)
            {
                if (Kontostand - Wert >= 0)
                    Kontostand -= Wert;
                else
                    throw new EingabeUngültigException("Sie dürfen nicht mehr abheben als Sie besitzen !");
            }
            else
            {
                throw new EingabeUngültigException("Der Wert darf nicht negativ sein !");
            }
        }

        public override void Einzahlen(decimal Wert)
        {
            if (Wert > 0)
            {
                Kontostand += Wert;
            }
            else
            {
                throw new EingabeUngültigException("Der Wert darf nicht negativ sein !");
            }
        }
    }
}
