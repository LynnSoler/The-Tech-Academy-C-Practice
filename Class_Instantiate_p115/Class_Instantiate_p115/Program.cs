using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Instantiate_p115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an integer to do math operations with");
            int valOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose a 2nd integer if you would like.. or press 'Enter' to continue without");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int val)) { val = Convert.ToInt32(input); }

            Integer ex = new Integer();
            Console.WriteLine(ex.Add(valOne, val));

            Console.ReadLine();
        }
    }
}