using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABO2_26102023
{
    internal class Camioneta : Vehiculo
    {

        private bool cabinaSimple;
        public Camioneta() : base(true,EPropulsion.Combustion)
        {
            cabinaSimple = true;
        }

        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(true,EPropulsion.Combustion)
        {
            this.cabinaSimple = cabinaSimple;

        }

        protected override string Tipo
        {
            get { return "Camioneta"; }
        }
        protected string GetInfo()
        {
            StringBuilder datos = new StringBuilder(base.GetInfo());
            if (cabinaSimple)
            {
                datos.Append(" Con Cabina simple.");
            }
            else
            {
                datos.Append(" Con cabina doble.");

            }
            return datos.ToString();
        }
    }
}
