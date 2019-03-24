using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    class Cliente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal SalarioBruto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Distrito { get; set; }

        public Cliente()
        {
            Edad = 20;
            FechaNacimiento = DateTime.Today.AddYears(-1 * Edad);
            //SalarioBruto = 960m;
            //Distrito = "Iquitos";
        }
    }
}
