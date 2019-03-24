namespace SistemaPrestamos
{
    public class Proveedor : Persona
    {
        public bool EsInternacional { get; set; }

        public void CalcularValores()
        {
            CalcularEdad();
            CalcularSueldo();
        }
    }
}