using System;
using System.Linq;

namespace Clase02
{
    class Program
    {
        static void Main(string[] parametros)
        {
            // Escribir cadena o string
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine("Cantidad de Argumentos: " + parametros.Length);

            // Condicionales

            if (parametros.Length > 0)
            {
                // String Interpolation o Interpolacion de cadenas.
                Console.WriteLine($"Mira mamá, ahora se programar, mi nombre es {parametros.FirstOrDefault()} y mi edad es {parametros.LastOrDefault()}.");
            }

            //Console.WriteLine("Mira mamá, ahora se programar, mi nombre es " 
            //                  + parametros.FirstOrDefault() 
            //                  + " y mi edad es " 
            //                  + parametros.LastOrDefault());


            Console.WriteLine($"La fecha actual es: {DateTime.Now:dd-MMMM-yyyy HH:mm:ss}");
            Console.WriteLine($"La fecha actual es: {DateTime.Now:g}");

            Console.WriteLine($"El tipo de cambio de hoy es: {3.38:C4}");
            Console.WriteLine($"El saldo de mi cuenta es: {23455663.38:C4}");

            Console.ReadLine();
        }
    }
}
