using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Instantiate_p114
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATE CLASS "MATH_METHODS"
            Integer_Methods method = new Integer_Methods();
            
            //CALL METHOD, PASS INTEGER & DISPLAY INT
            Console.WriteLine("We will take an integer, do a math operation to it, & display the answer as an integer" + method.methodOne(24));

            Console.WriteLine("We will take a decimal, do a math operation to it, & display the answer as an integer" + method.methodOne(678.99m));

            Console.WriteLine("We will take a string, do a math operation to it, & display the answer as an integer" + method.methodOne(36));

            Console.ReadKey();
        }
    }
}
