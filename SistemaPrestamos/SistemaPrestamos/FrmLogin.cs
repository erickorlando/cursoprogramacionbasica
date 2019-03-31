using System;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtClave.Text))
            {
                return;
            }

            if (txtUsuario.Text == txtClave.Text)
            {
                Program.UsuarioAutenticado = txtUsuario.Text;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(@"Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
