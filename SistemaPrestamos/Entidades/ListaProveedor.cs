using System;
using System.Collections.Generic;
using ErickOrlando.Utilidades.Data;

namespace SistemaPrestamos
{
    public class ListaProveedor : List<Proveedor>
    {
        public ListaProveedor()
        {
            var generator = new DataGenerator();

            for (int i = 0; i < 30; i++)
            {
                var proveedor = new Proveedor();
                proveedor.Nombre = generator.GetCompanyName();
                proveedor.FechaNacimiento = generator
                    .GetDate(Convert.ToDateTime("1985-01-01"), DateTime.Today);
                proveedor.Distrito = generator.GetStateAbbreviation();
                proveedor.CalcularValores();
                this.Add(proveedor);
            }
        }

    }
}
