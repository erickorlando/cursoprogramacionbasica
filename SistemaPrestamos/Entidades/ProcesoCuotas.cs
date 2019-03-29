using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPrestamos
{
    public class ProcesoCuotas
    {
        public string Cliente { get; set; }
        public decimal Interes { get; set; }
        public decimal MontoPrestamo { get; set; }
        public int CantidadCuotas { get; set; }
        public decimal TotalAPagar { get; set; }

        public ListaCuotas ListaCuotas { get; set; }

        public ProcesoCuotas()
        {
            ListaCuotas = new ListaCuotas();
            CantidadCuotas = 12;
            Interes = 5;
        }

        public void CalcularCuotas()
        {
            if (CantidadCuotas == 0 || MontoPrestamo == 0) return;

            var cantidadCuota = MontoPrestamo / CantidadCuotas;
            // Limpiar la colección.
            ListaCuotas.Clear();
            // Ciclos o bucles.
            for (int i = 0; i < CantidadCuotas; i++)
            {
                // la variable i contiene el contador actual.
                var cuotaCalculada = new CuotaCalculada();
                cuotaCalculada.MontoCuota = cantidadCuota;
                cuotaCalculada.FechaPago = DateTime.Today.AddMonths(i + 1);
                cuotaCalculada.Interes = (Interes / 100) * cantidadCuota;
                cuotaCalculada.Total = cuotaCalculada.MontoCuota + cuotaCalculada.Interes;

                ListaCuotas.Add(cuotaCalculada);
            }

            // realizar la suma total de Totales de cada elemento de la coleccion.
            //foreach (var cuota in ListaCuotas)
            //{
            //    TotalAPagar = TotalAPagar + cuota.Total;
            //}
            TotalAPagar = ListaCuotas.Sum(x => x.Total);
        }
    }

    // Esto representa una sola fila en la grilla de cuotas.
    public class CuotaCalculada
    {
        public decimal MontoCuota { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Interes { get; set; }
        public decimal Total { get; set; }
    }

    public class ListaCuotas : List<CuotaCalculada>
    {

    }
}