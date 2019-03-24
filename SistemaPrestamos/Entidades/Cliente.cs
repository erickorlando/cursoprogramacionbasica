using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    // Modificadores de Ambito
    /* public
     * internal
     * private
     * protected
     *
     * POO: Objetos de la vida real trasladados a código.
     * - Herencia.
     * - Polimorfismo.
     * - Encapsulamiento.
     * Está orientado a la reutilización de código.
     */


    public class Cliente : Persona
    {
        public Cliente()
        {
            FechaNacimiento = DateTime.Today.AddYears(-18);
            //SalarioBruto = 960m;
            //Distrito = "Iquitos";
        }

        public void CalcularValores()
        {
            // Aqui dentro de este metodo que sólo es para Clientes
            // vamos a llamar a las dos funcionalidades de la clase base.
            CalcularEdad();
            CalcularSueldo();
        }

        protected override void CalcularSueldo()
        {
            // CONDICION Y CONDICION 
            // CUANDO SE USA EL OPERADOR Y (AND) LAS DOS O MAS CONDICIONALES
            // DEBEN SER VERDADERAS
            if (Edad >= 18 && Edad <= 21)
            {
                SalarioBruto = 960;
            }

            // CUANDO SE USA OR (||) CUALQUIERA DE LAS CONDICIONALES SEAN VERDADERAS
            // DAN COMO RESULTADO VERDADERO.
            if (Edad >= 22 && Edad <= 40)
            {
                SalarioBruto = 4560;
            }
        }
    }
}
