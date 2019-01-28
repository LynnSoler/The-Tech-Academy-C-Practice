using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_p131
{
    
    //"PERSON" CLASS NOT NECESSARY FOR ASSMT; 
    //"EMPLOYEE" CLASS ONLY USED

    class Person
    {
        public string FirstName;
        public string LastName;

        public void SayName()
        {
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
        }

    }
}
