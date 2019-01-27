using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Inheritence_p124
{
    public class Employee : Person //"EMPLOYEE" CLASS INHERIT FROM "PERSON" CLASS
    {
        public override void SayName()
        {
            Console.WriteLine("First Name: " + FirstName); //=REMOVED FROM "PERSON", ADDED TO "EMP"
            Console.WriteLine("Last Name: " + LastName); //=REMOVED FROM "PERSON", ADDED TO "EMP"
        }
    }
}
