namespace SistemaPrestamos
{
    public partial class FrmClientes : FormularioPlantilla
    {
        private Cliente cliente;

        public FrmClientes()
        {
            InitializeComponent();
        }

        protected override void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            if (cliente == null) return;

            cliente.CalcularValores();
            
            MainForm.Instancia.ListaClientes.Add(cliente);

            clienteBindingSource.DataSource = MainForm.Instancia.ListaClientes;
            clienteBindingSource.ResetBindings(false);

            lblContador.Text = $@"La cantidad de registros es {MainForm.Instancia.ListaClientes.Count}";

            btnNuevo.PerformClick();
        }

        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            cliente = new Cliente();
            bsCliente.DataSource = cliente;
            bsCliente.ResetBindings(false);
            txtNombre.Focus();
        }

        private void FrmClientes_Load(object sender, System.EventArgs e)
        {
            clienteBindingSource.DataSource = MainForm.Instancia.ListaClientes;
            clienteBindingSource.ResetBindings(false);
        }
    }
}
