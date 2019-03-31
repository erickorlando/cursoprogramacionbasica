using System;
using System.Collections.Generic;
using ErickOrlando.Utilidades.Data;

namespace SistemaPrestamos
{
    public class ListaClientes : List<Cliente>
    {
        public ListaClientes()
        {
            var generator = new DataGenerator();

            for (int i = 0; i < 30; i++)
            {
                var cliente = new Cliente();
                cliente.Nombre = generator.GetFullName();
                cliente.FechaNacimiento = generator.GetDate(Convert.ToDateTime("1985-01-01"), DateTime.Today.AddYears(-10));
                cliente.Distrito = generator.GetStateAbbreviation();
                cliente.Correo = generator.GetEmail();

                cliente.CalcularValores();
                this.Add(cliente);
            }
        }
    }
}