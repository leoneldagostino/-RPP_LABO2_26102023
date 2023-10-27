using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPP_LABO2_26102023
{
    abstract class Vehiculo
    {
        protected bool esAWD;
        protected EPropulsion propulsion;
        protected Guid numeroDeChasis;

        public Vehiculo()
        {
            this.esAWD = false;
            this.numeroDeChasis = Guid.NewGuid();
        }
        protected Vehiculo(bool esAWD, EPropulsion propulsion) : this()
        {
            this.esAWD = esAWD;
            this.propulsion = propulsion;
        }

        protected Vehiculo(EPropulsion propulsion) : this()
        {
            this.propulsion = propulsion;
        }

        public EPropulsion Propulsion
        {
            get { return propulsion; }

        }

        protected abstract string Tipo
        {
            get; 
        }
        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            if (object.ReferenceEquals(vehiculo1, null) && object.ReferenceEquals(vehiculo2, null))
            {

                return true;
            }
            if (object.ReferenceEquals(vehiculo1, null) || object.ReferenceEquals(vehiculo2, null))
            {
                return false;

            }

            return vehiculo1.Tipo == vehiculo2.Tipo && vehiculo1.numeroDeChasis == vehiculo2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }

        public override bool Equals(object? obj)
        {
            
            if (obj is Vehiculo)
            {
                return this == (Vehiculo)obj;

            }
            return false;
            
        }

        public override int GetHashCode()
        {
            return numeroDeChasis.GetHashCode();
        }
        
        
        /// <summary>
        /// El metodo obtendra la informacion para saber si el vehiculo es (4x4) y lo agregara a su informacion
        /// </summary>
        /// <returns>Retornara los datos obtenidos del vehiculo</returns>
        protected string GetInfo()
        {
            
            string esAWDstring = "No";
            if (this.esAWD)
            {
                esAWDstring = "Si";
            }

            return string.Format($"{Tipo} con propulsion a {Propulsion},{esAWDstring} es AWD, numero de chasis: {numeroDeChasis}");
        }

       
       /// <summary>
       /// Obtendra los datos finales del vehiculo
       /// </summary>
       /// <returns>Retornara los datos del vehiculo.</returns>
       public override string ToString()
        {
            return GetInfo();
        }

    }
}
