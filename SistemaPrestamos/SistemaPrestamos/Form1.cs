using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, System.EventArgs e)
        {
            // if (condicion)  ====> Siempre va evaluar si la condicion se cumple 
            //if (txtNombre.Text.Length > 0)
            //    MessageBox.Show($@"Hola! ya se programar {txtNombre.Text}");

            // if (condicion)  ====> Siempre va evaluar si la condicion se cumple 
            //if (string.IsNullOrEmpty(txtEdad.Text))
            //{
            //    MessageBox.Show(@"No has ingresado la edad");
            //}
            //else
            //{
            //    MessageBox.Show($@"Tu edad es de {txtEdad.Text}");
            //}

            // NEGACION DE UNA CONDICION
            // if (!condicion)  ====> Siempre va evaluar si la condicion no se cumple 
            //if (!string.IsNullOrEmpty(txtEdad.Text))
            //{
            //    //if (char.IsDigit(txtEdad.Text[0]))
            //    //{
            //    //    MessageBox.Show($@"Tu edad es de {txtEdad.Text}");
            //    //}
            //    int edad = 0;
            //    if (int.TryParse(txtEdad.Text, out edad))
            //    {
            //        MessageBox.Show($@"Tu edad es de {edad}");
            //    }
            //}

            //if (!string.IsNullOrEmpty(txtClave.Text))
            //    //MessageBox.Show($@"Tu contraseña tiene {txtClave.Text.Length} caracteres");
            //    MessageBox.Show($@"Tu contraseña es {txtClave.Text}");

            int edad = 0;
            decimal sueldo;

            if (int.TryParse(txtEdad.Text, out edad) 
                && !string.IsNullOrEmpty(txtNombre.Text) 
                && !string.IsNullOrEmpty(txtClave.Text) 
                && !string.IsNullOrEmpty(txtSueldo.Text)
                && decimal.TryParse(txtSueldo.Text, out sueldo))
            {
                //string mensaje =
                //               $@"Hola {txtNombre.Text}, tu edad es {edad}. Tu contraseña tiene {txtClave.Text.Length} caracteres y tu sueldo es de {sueldo:C2}";

                //string mensaje =
                //    string.Format("Hola {0}, tu edad es {1}. Tu clave tiene {2} caracteres y tu sueldo es de {3:C2}",
                //        txtNombre.Text, edad, txtClave.Text, sueldo);

                string mensaje = "Hola " + txtNombre.Text + " tu sueldo es de " + sueldo.ToString("C2");

                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
    }
}
