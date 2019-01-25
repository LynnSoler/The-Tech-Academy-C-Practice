using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_p120
{
    public class Person
    {
        //PROPERTIES
        public string FirstName; // { get; set; }
        public string LastName; // { get; set; }

        public void SayName()
        {
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);

            //OR...
            //Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }
    }

}
