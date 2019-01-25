using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Instantiate_Static_p117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an integer to divide by 2");
            int num = Convert.ToInt32(Console.ReadLine());

            Integer ex = new Integer(); //INSTANTIATE CLASS "INTEGER"
            ex.Divide(num); //DIVIDE INPUT BY 2
            Console.Read();

            Integer ex2 = new Integer(); //2ND INSTANTIATION FOR CLASS "INTEGER"
            int a, b; 
            ex2.getVal(out a, out b); //OUTPUT PARAMATERS
            Console.WriteLine("After calling the method, value of a: {0}", a);
            Console.WriteLine("After calling the method, value of b: {0}", b);
            Console.ReadKey();

            Integer.var("test");
            Console.ReadLine();

        }
    }
}
