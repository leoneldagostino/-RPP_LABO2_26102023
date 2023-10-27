namespace View
{
    public partial class FrmFabrica : Form
    {
        public FrmFabrica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void FrmFabrica_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Automovil");
            cmbTipo.Items.Add("Moto");
            cmbTipo.Items.Add("Camioneta");
        }
        private Vehiculo CrearVehiculo(string tipo)
        {
            switch (tipo)
            {
                case "Automóvil":
                    return new Automovil();
                case "Camioneta":
                    return new Camioneta();
                case "Moto":
                    return new Moto();
                default:
                    return null;
            }
        }
    }
}