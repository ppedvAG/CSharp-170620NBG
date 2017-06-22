using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class MeineArgumente : EventArgs
    {
        public int Zahl1 { get; set; }
        public int Zahl2 { get; set; }

        public string NeuerString { get; set; }
    }
}
