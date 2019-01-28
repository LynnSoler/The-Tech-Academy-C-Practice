using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_p156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; //PRINT CURRENT DATE/TIME TO CONSOLE
            Console.WriteLine(now);
            Console.WriteLine("Enter a whole number to see what time it will be in your chosen number of hours"); //ASK USER FOR NUM
            TimeSpan Xhours = TimeSpan.FromHours(Convert.ToDouble(Console.ReadLine()));
            DateTime inXHours = now + Xhours;
            Console.WriteLine("The exact time will be: " + inXHours); //PRINT EXACT TIME IT WILL BE IN XHOURS (XHOURS = NUM USER PREVIOUSLY ENTERED)

            Console.Read();
        }
    }
}
