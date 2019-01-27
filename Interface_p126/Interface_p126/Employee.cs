using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_p126
{
    public class Employee : Person, IQuittable //"EMPLOYEE" CLASS INHERIT FROM "PERSON" CLASS & INHERIT "QUIT()" METHOD
    {
        public override void SayName()
        {
            Console.WriteLine("First Name: " + FirstName); //=REMOVED FROM "PERSON", ADDED TO "EMP"
            Console.WriteLine("Last Name: " + LastName); //=REMOVED FROM "PERSON", ADDED TO "EMP"
        }

        public void Quit() //QUIT() METH IMPLEMENTATION
        {
            Console.WriteLine("I've implemented the Quit() Method");
        }
    }
}
