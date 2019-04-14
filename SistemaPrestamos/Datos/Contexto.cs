using SistemaPrestamos;
using System.Data.Entity;

namespace Datos
{
    public class Contexto : DbContext
    {
        public Contexto()
            :base("name=PrestamosDb")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
