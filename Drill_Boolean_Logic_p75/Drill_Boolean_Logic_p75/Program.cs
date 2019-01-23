using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Boolean_Logic_p75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer with True or False.");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int userTix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Are you qualified?");
            Console.WriteLine("");
            bool Qualified = (userAge > 15) && (userDUI != true) && (userTix <= 3);

                if (Qualified == true)
                    {
                        Console.WriteLine("You're qualified!");
                    }

                else
                    {
                    Console.WriteLine("We apologize, but you are not qualified at this time.");
                    }

            Console.ReadLine();

        }
    }
}
