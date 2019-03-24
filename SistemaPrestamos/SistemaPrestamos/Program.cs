using System;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cargamos una instancia de la clase FrmLogin
            // y si el usuario es correcto, abre el formulario de Registro.
            var login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmProveedor());
            }

            //Application.Run(new FrmRegistro());
        }
    }
}
