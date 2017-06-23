using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRottDLL
{
    public class Girokonto : Konto
    {
        public Girokonto(string Inhaber, int Kontonummer, int Pin,decimal Überziehungsrahmen, decimal Kontostand = 0) : base(Inhaber, Kontonummer, Pin, Kontostand)
        {
            this.Überziehungsrahmen = Überziehungsrahmen;
        }

        public decimal Überziehungsrahmen { get; private set; }

        public override void Abheben(decimal Wert)
        {
            if (Wert > 0)
            {
                if(Kontostand - Wert >= Überziehungsrahmen)
                    Kontostand -= Wert;
                else
                    throw new EingabeUngültigException($"Sie würden den Überziehungsrahmen von {Überziehungsrahmen} überschreiten. Transaktion abgebrochen.");
            }
            else
            {
                throw new EingabeUngültigException("Der Wert darf nicht negativ sein !");
            }
        }

        public override void Einzahlen(decimal Wert)
        {
            if(Wert > 0)
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
