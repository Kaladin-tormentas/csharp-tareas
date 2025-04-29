using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresa_dos_numeros_y_multiplica
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double num1, num2;

            Console.WriteLine("Digite el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine(" Digite el segundo número: ");
            num2= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n El producto es: " +(num1*num2));




        }
    }
}
