using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienbenido a la Rostiseria");
            Console.WriteLine("¿Que desea ordenar?");
            string orden = Console.ReadLine();
            Console.WriteLine("¿Cuantas unidades desea?");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Desea agregar algo mas a su orden? (S/N)");
            string respuesta = Console.ReadLine();
            if (respuesta == "S")
            {
                Console.WriteLine("¿Que desea ordenar?");
                string orden2 = Console.ReadLine();
                Console.WriteLine("¿Cuantas unidades desea?");
                int cantidad2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Su orden es: " + cantidad + " unidades de " + orden + " y " + cantidad2 + " unidades de " + orden2);
            }
            else
            {
                Console.WriteLine("Su orden es: " + cantidad + " unidades de " + orden);
            }
            Console.WriteLine("Gracias por su compra");
        }
    }
}
