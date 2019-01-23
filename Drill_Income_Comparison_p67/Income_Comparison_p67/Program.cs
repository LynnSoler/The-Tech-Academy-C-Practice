using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison_p67
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Greet
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            double hourly1 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work every week?");
            double hoursWeek1 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            
            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            double hourly2 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work every week?");
            double hoursWeek2 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            //Salary Comparison
            double annualSalary1 = (hourly1 * hoursWeek1) * 52;
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(annualSalary1);

            double annualSalary2 = (hourly2 * hoursWeek2) * 52;
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool comparison = annualSalary1 > annualSalary2;
            Console.WriteLine(comparison);
            Console.ReadLine();
        }
    }
}
