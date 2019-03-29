using System;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class MainForm : Form
    {
        public static MainForm Instancia;

        public ListaClientes ListaClientes = new ListaClientes();

        public MainForm()
        {
            InitializeComponent();
            Instancia = this;
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // la instrucción using sólo funciona siempre y cuando la clase
            // implemente una interfaz llamada IDisposable.
            using (var frm = new FrmProveedor())
            {
                frm.ShowDialog(); // Esta linea detiene el compilador.
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmClientes())
            {
                frm.ShowDialog();
            }
        }

        private void calcularCuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCalcularCuotas())
            {
                frm.ShowDialog();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Text = $@"Sistema de Préstamos - Bienvenido: {Program.UsuarioAutenticado}";
        }
    }
}
