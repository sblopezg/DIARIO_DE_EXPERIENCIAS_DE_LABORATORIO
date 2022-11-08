using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1__S.B.L_1104822
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            string edad = Console.ReadLine();
            Console.WriteLine("Ingrese carrera");
            string carrera = Console.ReadLine();
            Console.WriteLine("Ingrese carne");
            string carne = Console.ReadLine();

            Console.WriteLine("soy"+ nombre + "tengo "+ edad + "años y estudio la carrera de" + carrera + "mi numero de carne" + carne);
            Console.ReadKey();
        }
    }
}
