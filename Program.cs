// Este es un codigo usando instrucciones de nivel superior.

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// Este es un codigo en el cual no usamos instrucciones de nivel superior en el codigo  esta era la manera tradicciona de hacerlo como siempre.

/**
    * asi se veria si no usamos instrucciones de nivel superior
    * esta es la forma que se usa en proyectos mas grandes
    * por mayor orden de codigo utilizamos todas las estructuras
 */

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

			//Esperamos ejecucion y cierre de la consola.
			Console.ReadKey();
        }
    }
}