using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABO2_26102023
{
    internal class Automovil : Vehiculo
    {
        public Automovil() : base (EPropulsion.Hibrido)
        {
        }

        protected override string Tipo
        {
            get { return "Automovil"; }
        }
    }
}
