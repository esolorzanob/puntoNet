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
            List<int> lista = new List<int>();
            for (var i=0; i < 5; i++) {
                lista.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine(lista[0]);
            Console.WriteLine(String.Join(",", lista));
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
