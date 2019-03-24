using System;

namespace SistemaPrestamos
{
    public partial class FrmProveedor : FormularioPlantilla
    {
        private Proveedor proveedor;
        private ListaProveedor listaProveedor = new ListaProveedor();

        public FrmProveedor()
        {
            InitializeComponent();
        }

        protected override void btnNuevo_Click(object sender, EventArgs e)
        {
            proveedor = new Proveedor();
            CargarControles(proveedorBindingSource, proveedor);
            nombreTextBox.Focus();
        }

        protected override void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (proveedor == null) return;
            proveedor.CalcularValores();

            listaProveedor.Add(proveedor);
            CargarControles(bslistaProveedor, listaProveedor);

            lblContador.Text = $@"La cantidad de registros es {listaProveedor.Count}";
            
            btnNuevo.PerformClick();
        }
    }
}
