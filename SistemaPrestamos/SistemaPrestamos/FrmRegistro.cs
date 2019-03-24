using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class FrmRegistro : Form
    {
        private List<Cliente> listaClientes = new List<Cliente>();
        private Cliente cliente;

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            //var cliente = new Cliente();
            //cliente.Nombre = txtNombre.Text;
            //if (int.TryParse(txtEdad.Text, out var edad))
            //{
            //    cliente.Edad = edad;
            //}

            //if (decimal.TryParse(txtSueldo.Text, out var sueldo))
            //{
            //    cliente.SalarioBruto = sueldo;
            //}

            if (cliente == null) return;

            listaClientes.Add(cliente);

            clienteBindingSource.DataSource = listaClientes;
            clienteBindingSource.ResetBindings(false);

            lblContador.Text = $@"La cantidad de registros es {listaClientes.Count}";

            btnNuevo.PerformClick();
        }

        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
            cliente = new Cliente();
            bsCliente.DataSource = cliente;
            bsCliente.ResetBindings(false);
            txtNombre.Focus();
        }
    }
}
