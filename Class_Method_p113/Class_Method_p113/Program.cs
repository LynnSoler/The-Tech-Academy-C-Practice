using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_p113
{
    class Program
    {
        public static void Main(string[] args)
        {
            //4.) CALL METHOD & SPECIFY PARAMETERS BY NAME
            Console.WriteLine("Choose an integer (whole #) to do math operations with");
            int valOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose another integer to do math operations with");
            int valTwo = Convert.ToInt32(Console.ReadLine());

            Integer ex = new Integer();
            ex.Add(valOne, valTwo);
            
            //3.) CALL METHOD IN THE CLASS & PASS IN 2 NUMS
            ex.Add(1, 9);

            Console.ReadLine();
        }
    }
}
