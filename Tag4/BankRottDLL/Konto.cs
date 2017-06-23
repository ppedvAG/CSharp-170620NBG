using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRottDLL
{
    public abstract class Konto
    {
        public string Inhaber { get; private set; }
        public int Kontonummer { get; } //ReadOnly - Property -> Wert kann nur im Konstruktor gesetzt werden
        private readonly int Pin; // ReadOnly - Feld -> Wert kann nur im Konstruktor gesetzt werden
        public decimal Kontostand { get; protected set; } // Zugriff von Jugendkonto und Girokonto

        public abstract void Einzahlen(decimal Wert);
        public abstract void Abheben(decimal Wert);

        // ctor + TAB + TAB
        public Konto(string Inhaber,int Kontonummer,int Pin,decimal Kontostand = 0)
        {
            this.Inhaber = Inhaber;
            this.Kontonummer = Kontonummer;
            this.Pin = Pin;
            this.Kontostand = Kontostand;
        }

        public bool CheckPin(int Pin)
        {
            //if (this.Pin == Pin)
            //    return true;
            //else
            //    return false;

            return this.Pin == Pin;
        }
    }
}
