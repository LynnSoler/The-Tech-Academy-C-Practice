using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Instantiate_Static_p117
{
    class Integer
    {
        public void Divide(int num) //VOID METHOD TO OUTPUT INT
        {
            Console.WriteLine(num / 2); //DIVIDE PASSED INT BY 2
        }

        public void getVal(out int x, out int y) //OUTPUT PARAMETERS
        {
            Console.WriteLine("Please enter a value");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a 2nd value");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public static void var(int x)
        {
            Console.WriteLine("var(int x)");
        }

        public static void var(string y)
        {
            Console.WriteLine("var(string y)");
        }

    }
}
