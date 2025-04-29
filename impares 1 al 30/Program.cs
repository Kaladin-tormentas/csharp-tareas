using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impares_1_al_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;

            Console.WriteLine(" Los números impares del 1 al 30 son: ");

            while (contador <= 30) {

                if ((contador%2) !=0) {

                    Console.WriteLine(contador);

                
                }
                
                
                contador++; }





        }
    }
}
