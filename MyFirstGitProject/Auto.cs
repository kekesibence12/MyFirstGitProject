using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitProject
{
    class Auto
    {
        private string marka;
        private string modell;
        private int évjárat;
        private int kilometer;
        private string uzemanyag;
        private int ar;

        public Auto(string marka, string modell, int évjárat, int kilometer, string uzemanyag, int ar)
        {
            this.marka = marka;
            this.modell = modell;
            this.évjárat = évjárat;
            this.kilometer = kilometer;
            this.uzemanyag = uzemanyag;
            this.ar = ar;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int Évjárat { get => évjárat; set => évjárat = value; }
        public int Kilometer { get => kilometer; set => kilometer = value; }
        public string Uzemanyag { get => uzemanyag; set => uzemanyag = value; }
        public int Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            return String.Format("Márka: {0}, Modell: {1}, Évjárat: {2}, Kilométer: {3}, Uzemanyag: {4}, Ár: {5}", Marka, Modell, Évjárat, Kilometer, Uzemanyag, Ar);
        }
    }
}
