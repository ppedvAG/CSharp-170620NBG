using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRottDLL
{
    public class EingabeUngültigException : Exception
    {
        public EingabeUngültigException(string Message) : base(Message) // Konstruktor der Basisklasse wird aufgerufen, bevor der eigene Konstruktor aufgerufen wird
        {
        }
    }
}
