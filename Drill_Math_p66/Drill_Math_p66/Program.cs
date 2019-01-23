using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Math_p66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to multiply by 50");
            string numFirst = Console.ReadLine();
            int firstNum = Convert.ToInt32(numFirst);
            int totFirst = 50 * firstNum;
            Console.WriteLine(totFirst);
            Console.Read();

            Console.WriteLine("Type a number to add 25 to");
            string numSec = Console.ReadLine();
            int secondNum = Convert.ToInt32(numSec);
            int totSec = secondNum + 25;
            Console.WriteLine(totSec);
            Console.Read();

            Console.WriteLine("Type a number to divide by 12.5");
            string numThird = Console.ReadLine();
            int thirdNum = Convert.ToInt32(numThird);
            double totThird = thirdNum / 12.5;
            Console.WriteLine(totThird);
            Console.ReadLine();

            Console.WriteLine("Type a number to check if it is greater than 50");
            string numFourth = Console.ReadLine();
            int fourthNum = Convert.ToInt32(numFourth);
            bool truthorfalse = fourthNum > 50;
            Console.WriteLine(truthorfalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Type a number to divide by 7 and show the remainder");
            string numFifth = Console.ReadLine();
            int FifthNum = Convert.ToInt32(numFifth);
            int remain = 7 % FifthNum;
            Console.WriteLine(remain);
            Console.ReadLine();

        }
    }
}
