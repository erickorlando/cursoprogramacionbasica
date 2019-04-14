using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace SistemaPrestamos
{
    public partial class FrmCalcularCuotas : Form
    {
        private ProcesoCuotas _procesoCuotas;

        public FrmCalcularCuotas()
        {
            InitializeComponent();
        }

        private void FrmCalcularCuotas_Load(object sender, EventArgs e)
        {
            listaClientesBindingSource.DataSource = MainForm.Instancia.ListaClientes;
            listaClientesBindingSource.ResetBindings(false);

            _procesoCuotas = new ProcesoCuotas();

            bsProcesoCuotas.DataSource = _procesoCuotas;
            bsProcesoCuotas.ResetBindings(false);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            _procesoCuotas.CalcularCuotas();

            bsProcesoCuotas.ResetBindings(false);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaClientesBindingSource.Current == null) return;

            var cliente = listaClientesBindingSource.Current as Cliente;

            lblFechaNacimiento.Text = cliente.FechaNacimiento.ToShortDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var reporte = new ReportePrestamo();
            reporte.Parameters["Cliente"].Value = _procesoCuotas.Cliente;
            reporte.Parameters["Monto"].Value = _procesoCuotas.MontoPrestamo;
            reporte.Parameters["Interes"].Value = _procesoCuotas.Interes;
            reporte.Parameters["Cuotas"].Value = _procesoCuotas.CantidadCuotas;

            reporte.DataSource = _procesoCuotas.ListaCuotas;
            reporte.ShowRibbonPreviewDialog();
        }
    }
}
