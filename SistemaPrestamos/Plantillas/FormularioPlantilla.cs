using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class FormularioPlantilla : Form
    {
        public FormularioPlantilla()
        {
            InitializeComponent();
        }

        protected virtual void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        // Sobrecarga
        // Se diferencian por el tipo de dato que se recibe en los parametros.

        protected void CargarControles(BindingSource bindingSource, Persona persona)
        {
            bindingSource.DataSource = persona;
            bindingSource.ResetBindings(false);
        }

        protected void CargarControles(BindingSource bindingSource, object objeto)
        {
            bindingSource.DataSource = objeto;
            bindingSource.ResetBindings(false);
        }

        protected virtual void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
