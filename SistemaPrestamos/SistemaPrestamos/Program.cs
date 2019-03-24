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

            var login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmRegistro());
            }

            //Application.Run(new FrmRegistro());
        }
    }
}
