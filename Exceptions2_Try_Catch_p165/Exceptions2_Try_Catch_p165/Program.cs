using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2_Try_Catch_p165
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?"); //ASK USER AGE
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0) { throw new FormatException(); }
                if (age > 110) { throw new Exception(); }
                int year = 2019 - age;
                Console.WriteLine("You were likely born in " + year + " ...+/- 1 year"); //PRINT YR USER IS BORN
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Error. Zero or negative numbers are not valid"); //ERROR MSSG FOR 0 OR (-)NUMS
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //ERROR MSSG REPEATED FOR ANY OTHER INPUT (IE: TEXT OR SYMBOL)
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
