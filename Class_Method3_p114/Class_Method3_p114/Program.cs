using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method3_p114
{
    class Program
    {
        public static void Main(string[] args)
        {
            //CALL METHOD & PASS IN INTEGER
            Console.WriteLine("Choose an integer to do math operations with");
            int valOne = Convert.ToInt32(Console.ReadLine());

            //CALL METHOD & PASS IN DECIMAL
            Console.WriteLine("Choose a decimal number to do math operations with");
            decimal valTwo = Convert.ToInt32(Console.ReadLine());

            //CALL METHOD, PASS IN STRING & CONVERT TO INTEGER
            Console.WriteLine("Choose a number to convert to an integer & do math operations with");
            string valThree = Console.ReadLine();

            Integer ex = new Integer(); //OBJECT CREATION

            Console.WriteLine(ex.MathOperation(valOne));
            Console.WriteLine(ex.MathOperation(valTwo));
            Console.WriteLine(ex.MathOperation(valThree));

            Console.ReadLine();
        }
    }
}
