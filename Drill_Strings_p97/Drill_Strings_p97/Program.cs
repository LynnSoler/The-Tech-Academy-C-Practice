using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Strings_p97
{
    class Program
    {
        static void Main()
        {
            //STRINGS
            string name = "Bob Smith";
            string pets = "3 snakes";
            string favFood = "brownies!";

            //CONCATENATE STRINGS
            string concatenate = "Hi, my name is " + name + " I have " + pets + " and I love " + favFood;
            Console.WriteLine(concatenate);
            Console.ReadLine();

            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            //STRINGBUILDER
            StringBuilder build = new StringBuilder();
            build.Append("My name is Bob Smith.");
            build.Append(" I work at Rausch Motors.");
            build.Append(" I currently am enrolled at The Tech Academy.");
            build.Append(" My favorite animal is the kangaroo.");
            build.Append(" My favorite food is pizza.");
            build.Append(" My favorite condiment is mango chutney.");

            Console.WriteLine(build);
            Console.ReadLine();

        }
    }
}
