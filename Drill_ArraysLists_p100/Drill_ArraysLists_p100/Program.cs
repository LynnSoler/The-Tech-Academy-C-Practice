using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_ArraysLists_p100
{
    class Program
    {
        static void Main()
        {
            //ARRAY OF STRINGS
            string[] colorArray = new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple" };
            Console.WriteLine("Choose a number from 0-5 to display the string at that index of the array.");
            int input = Convert.ToInt32(Console.ReadLine());
            
            while (input < 0 || input > 5) //DNE MESSAGE TO USER
            {
                Console.WriteLine("Error. Please enter a number between 0 and 5.");
                input = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The color at index " + input + " is " + colorArray[input]);
            Console.ReadLine();

            //ARRAY OF INTEGERS
            int[] intArray = { 0, 1, 20, 100, 500, 7000, 8000 };
            Console.WriteLine("Choose a number from 0-6 to display the integer at that index of the array.");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            
            while (inputInt < 0 || inputInt > 6) //DNE MESSAGE TO USER
            {
                Console.WriteLine("Error. Please enter a number between 0 and 6.");
                inputInt = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The integer at index " + inputInt + " is " + intArray[inputInt]);
            Console.ReadLine();

            //LIST OF STRINGS
            List<string> stringList = new List<string>();
            stringList.Add("Red");
            stringList.Add("Orange");
            stringList.Add("Yellow");
            stringList.Add("Green");
            stringList.Add("Blue");
            stringList.Add("Purple");

            Console.WriteLine("Choose a number from 0-5 to display the string at that index of the list.");
            int listInput = Convert.ToInt32(Console.ReadLine());

            while (listInput < 0 || listInput > 5)
            {
            Console.WriteLine("Error. Please enter a number between 0 and 5.");
            listInput = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The color at index " + listInput + " is " + stringList[listInput]);
            Console.ReadLine();
        }
    }
}
