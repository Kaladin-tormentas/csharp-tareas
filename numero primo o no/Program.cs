using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace numero_primo_o_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 2;
            bool bandera = true;
            double num;

            Console.WriteLine(" Digite el número: ");

             num = Convert.ToDouble(Console.ReadLine());

            while (cont < Math.Sqrt(num))
            {

                if ((num % cont) == 0 && (num != 2))
                {

                    bandera = false;

                    break;

                }
                cont++;
            }



            if (num < 2)
            {
                bandera = false;
            }

            if (bandera== true)
            {
                Console.WriteLine("\n El número " + num + " es un número primo.");
            }
            else { Console.WriteLine("\n El número " + num + " no es un número primo."); }
        }
    }
}
        
    