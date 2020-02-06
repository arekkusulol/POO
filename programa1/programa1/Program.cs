using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa1
{
    class Program
    {
        private static object console;

        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("introduce un numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("introduce un numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("La suma es de los numeros es: " + c);
            Console.ReadKey();
        }
    }
}
