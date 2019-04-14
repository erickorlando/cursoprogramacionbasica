using System;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    static class Program
    {
        public static string UsuarioAutenticado { get; set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Vamos a establecer el idioma que usará la aplicación
            // Referencia Cultural.
            // ingles EEUU => FECHA CORTA => MES/DIA/AÑO
            // ingles GB (INGLATERRA) => FECHA CORTA => DIA/MES/AÑO
            // Español de España => Formato Numerico => Separador de Decimales la coma.

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("es-PE");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-PE");

            // Cargamos una instancia de la clase FrmLogin
            // y si el usuario es correcto, abre el formulario de Registro.
            var login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }

        }
    }
}
