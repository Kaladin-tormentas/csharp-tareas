using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cudratica
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double a, b, c,d, x1, x2;

            Console.Write(" digite el valor de a : ");
            a=Convert.ToDouble(Console.ReadLine());

            Console.Write(" digite el valor de b : ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write(" digite el valor de c : ");
            c = Convert.ToDouble(Console.ReadLine());



            Console.Write("\n su cuadratica es:  " + a + "x^2");

            if (b >= 0) { Console.Write("+" + b + "x"); }else { Console.Write( b+"x"); }

            if (c >= 0) { Console.Write("+" + c + "=0" ); } else { Console.Write(c+"=0"); }


            x1 = (-(b) + Math.Sqrt(((Math.Pow(b,2))+ (-4) * a * c)) )/ (2 * a);

            x2 = (-(b) - Math.Sqrt(((Math.Pow(b,2))+ (-4) * a * c)) )/ (2 * a);

            d = ((b * b) + ((-4) * a * c));

            if (d < 0)
            {
                Console.WriteLine("\n \n" +
                " cuadratica imposible de resolver, determinante menor que cero.");
            }
            else
            {

                Console.WriteLine("\n\nx1= " + x1);
                Console.WriteLine("x2= " + x2);

            }





        }
    }
}
