using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_p106
{
    class Program
    {
        static void Main(string[] args)
        {
            // <TRY-CATCH>
            try
            {
            //LIST OF INTEGERS
            //ASK USER FOR # TO DIVIDE EACH NUM IN LIST BY
            //LOOP TO TAKE EA INTEGER IN LIST, DIVIDE BY USER #, & DISPLAY RESULT
            List<int> numList = new List<int>() { 1, 2, 2, 34, 578, 8123};
            Console.WriteLine("Choose a number to divide each number in the list by");
                string num1 = Console.ReadLine();
                int numDiv = Convert.ToInt32(num1);

                for (int i = 0; i < numList.Count; i++)
                {
                    Console.WriteLine(numList[i] / numDiv);
                }

                Console.ReadLine();
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine("Type a whole number");
                return;
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error. You cannot divide by zero.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //</TRY-CATCH>


            finally
            {
                Console.ReadLine();
            }
        }
    }
}
