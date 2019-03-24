using System;

namespace SistemaPrestamos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal SalarioBruto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Distrito { get; set; }

        public void CalcularEdad()
        {
            // Cuando restamos fechas, me devuelve una clase llamada TimeSpan.
            // Me devuelve sólo la cantidad horas, minutos, segundos y milisegundos.
            var OtraFecha = DateTime.Today.AddYears(-1 * FechaNacimiento.Year);
            Edad = OtraFecha.Year;
        }

        protected virtual void CalcularSueldo()
        {
            switch (Edad)
            {
                case 18:
                case 19:
                    SalarioBruto = 930;
                    break;
                case 20:
                    SalarioBruto = 1000;
                    break;
                case 30:
                    SalarioBruto = 2000;
                    break;
                case 40:
                    SalarioBruto = 4000;
                    break;
                default:
                    SalarioBruto = new Random(5000).Next();
                    break;
            }
        }
    }
}