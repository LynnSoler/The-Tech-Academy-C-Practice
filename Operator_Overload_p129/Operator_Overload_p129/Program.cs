using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload_p129
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee n1 = new Employee();
            Employee n2 = new Employee();

            n1.id = 21;
            n2.id = 45;

            bool yes = n1 == n2;
            bool no = n1 != n2;

            Employee emp1 = new Employee(); //"EMPLOYEE" OBJ
            emp1.FirstName = "Sample"; //INSTANTIATE EMP OBJ W/"SAMPLE"
            emp1.LastName = "Student"; //INSTANTIATE EMP OBJ W/"STUDENT"
            emp1.SayName(); //CALL SUPERCLASS "SAYNAME()" ON EMP OBJ

            IQuittable ex = new Employee(); //"IQUITTABLE" OBJ
            ex.Quit(); //CALL METHOD QUIT()

            Console.ReadLine();
        }
    }
}
