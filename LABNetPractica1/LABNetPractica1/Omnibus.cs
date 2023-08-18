using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNetPractica1
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int CantPasajeros) : base(CantPasajeros)
        {

        }

        public override string Tipo => "Omnibus";
        public override int Num => ContadorOmnibus++;

        public override string Avanzar()
        {
            return $"El omnibus está avanzando";
        }

        public override string Detenerse()
        {
            return $"El omnibus se detuvo";
        }
    }
}
