using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opcion 1. Ingresar un monto\nOpcion 2. Mostrar total de factura");
            var opcion = int.Parse(Console.ReadLine());
            var monto = 0;
            while (opcion != 2) {
                Console.WriteLine("Por favor ingrese el Monto ");
                monto = monto + int.Parse(Console.ReadLine());

                Console.WriteLine("Opcion 1. Ingresar un monto\nOpcion 2. Mostrar total de factura");
                opcion = int.Parse(Console.ReadLine());
            }
            var impuesto = monto * 0.13;
            var total = impuesto + monto;
            Console.WriteLine("El monto total de la factura es " +total);
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.Read();
        }
    }
}
