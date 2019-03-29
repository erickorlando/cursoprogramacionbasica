﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
