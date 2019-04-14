using Datos;
using System;
using System.Windows.Forms;

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

            if (cliente.EsNuevo)
            {
                MainForm.Instancia.ListaClientes.Add(cliente);
            }

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

        protected override void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtener el registro seleccionado en la grilla.
            if (clienteBindingSource.Current == null) return;

            var seleccionado = clienteBindingSource.Current as Cliente;
            seleccionado.EsNuevo = false;

            CargarControles(bsCliente, seleccionado);
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el registro seleccionado en la grilla.
            if (clienteBindingSource.Current == null) return;

            if (MessageBox.Show("Está seguro que desea eliminar?", "Confirme", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;


            var seleccionado = clienteBindingSource.Current as Cliente;

            MainForm.Instancia.ListaClientes.Remove(seleccionado);

            clienteBindingSource.ResetBindings(false);

        }

        private void FrmClientes_Load(object sender, System.EventArgs e)
        {
            clienteBindingSource.DataSource = MainForm.Instancia.ListaClientes;
            clienteBindingSource.ResetBindings(false);
        }

        private void BtnGrabarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new Contexto())
                {
                    foreach (var cliente in MainForm.Instancia.ListaClientes)
                    {
                        ctx.Set<Cliente>().Add(cliente);
                    }
                    ctx.SaveChanges();
                }

                MessageBox.Show("Se terminó de grabar todo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
