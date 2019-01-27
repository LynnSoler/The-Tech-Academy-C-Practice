using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_p126
{
    public abstract class Person
    {
        //PROPERTIES
        public string FirstName; // { get; set; }
        public string LastName; // { get; set; }

        public abstract void SayName();

    }
}
