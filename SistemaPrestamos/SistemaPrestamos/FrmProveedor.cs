using System;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class FrmProveedor : FormularioPlantilla
    {
        private Proveedor proveedor;

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

            if (proveedor.EsNuevo)
                MainForm.Instancia.ListaProveedores.Add(proveedor);

            CargarControles(bslistaProveedor, MainForm.Instancia.ListaProveedores);

            lblContador.Text = $@"La cantidad de registros es {MainForm.Instancia.ListaProveedores.Count}";

            btnNuevo.PerformClick();
        }

        protected override void btnEditar_Click(object sender, EventArgs e)
        {
            // Nueva característica de C# 7.0 llamada Pattern Matching.

            if (!(bslistaProveedor.Current is Proveedor seleccionado)) return;

            seleccionado.EsNuevo = false;

            CargarControles(proveedorBindingSource, seleccionado);
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!(bslistaProveedor.Current is Proveedor seleccionado)) return;

            if (MessageBox.Show("Está seguro que desea eliminar?", "Confirme", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;

            MainForm.Instancia.ListaProveedores.Remove(seleccionado);

            CargarControles(bslistaProveedor, MainForm.Instancia.ListaProveedores);
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            btnNuevo.PerformClick();
            CargarControles(bslistaProveedor, MainForm.Instancia.ListaProveedores);
        }
    }
}
