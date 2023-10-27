namespace RPP_LABO2_26102023
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;


        private Fabrica()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Fabrica(int capacidad)
        {
            this.capacidad = capacidad;
           
        }
        public List<Vehiculo> Vehiculos
        {
            get { return vehiculos; }   
        }

        public static Fabrica CrearFabrica(int capacidad)
        {
            if (capacidad > 0)
            {
                return new Fabrica(capacidad);
            }
            throw new ArgumentException("La capacidad debe ser mayor que cero.");
        }        
        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.Vehiculos.Count < Fabrica.capacidad)
            {
                fabrica.Vehiculos.Add(vehiculo);
            }
            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            int index = fabrica.Vehiculos.FindIndex(v => v.Tipo == vehiculo.Tipo && v.numeroDeChasis == vehiculo.numeroDeChasis);
            if (index >= 0)
            {
                fabrica.Vehiculos.RemoveAt(index);
            }
            return fabrica;
        }        
    }
}