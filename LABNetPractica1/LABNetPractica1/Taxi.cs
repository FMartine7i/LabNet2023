using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABNetPractica1
{
    internal class Taxi : TransportePublico
    {
        public Taxi(int CantPasajeros) : base(CantPasajeros)
        {

        }

        public override string Tipo => "Taxi";
        public override int Num => ContadorTaxi++;

        public override string Avanzar()
        {
            return $"El taxi está avanzando";
        }

        public override string Detenerse()
        {
            return $"El taxi se detuvo";
        }
    }
}
