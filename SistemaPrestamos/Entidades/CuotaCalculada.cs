using System;

namespace SistemaPrestamos
{
    // Esto representa una sola fila en la grilla de cuotas.
    public class CuotaCalculada
    {
        public decimal MontoCuota { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Interes { get; set; }
        public decimal Total { get; set; }
    }
}