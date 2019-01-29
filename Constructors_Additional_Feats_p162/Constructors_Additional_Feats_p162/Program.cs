using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Additional_Feats_p162
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ex = new Employee("Michelle", "Obama", 20);
            ex.printName();

            Console.ReadLine();
        }        
    }
}
