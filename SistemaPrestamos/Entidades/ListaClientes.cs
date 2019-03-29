using System;
using System.Collections.Generic;

namespace SistemaPrestamos
{
    public class ListaClientes : List<Cliente>
    {
        public ListaClientes()
        {
            for (int i = 0; i < 30; i++)
            {
                var cliente = new Cliente();
                cliente.Nombre = $"Cliente N° {i + 1}";
                cliente.FechaNacimiento = new DateTime(1967 + i, 4, 1 );
                cliente.CalcularValores();
                this.Add(cliente);
            }
        }
    }
}