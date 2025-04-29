using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_1_al_50
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num1=0, num2=1;

            while (num2 < 50)
            {

                Console.WriteLine(num2);
                
                num2 = num2 + num1;
                num1 = num2-num1;
            }



        }
    }
}
