using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNetPractica1
{
    public abstract class TransportePublico
    {
        public static int ContadorTaxi = 1;
        public static int ContadorOmnibus = 1;

        public abstract int Num { get; }

        public int CantPasajeros { get; set; }

        public TransportePublico(int CantPasajeros) {
            this.CantPasajeros = CantPasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detenerse();

        public abstract string Tipo { get; }
    }
}
