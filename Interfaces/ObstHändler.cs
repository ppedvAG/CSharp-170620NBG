using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ObstHändler
    {
        public IProdukt Produkt { get; set; }
        public int Anzahl { get; set; }

        public void Verkaufen(int Anzahl)
        {
            this.Anzahl -= Anzahl;
        }
    }
}
