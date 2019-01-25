using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_p111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an integer (whole #) you would like to do math operations with.");
            int valOne = Convert.ToInt32(Console.ReadLine());

            Integer example = new Integer(); //OBJECT CREATION
            example.Add(valOne);
            example.Subtract(valOne);
            example.Multiply(valOne);


            Console.ReadLine();
        }
    }
}
