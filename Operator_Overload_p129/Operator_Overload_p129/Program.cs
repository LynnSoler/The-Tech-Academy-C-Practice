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
            Employee int1 = new Employee();
            Employee int2 = new Employee();

            int1.id = 23;
            int2.id = 52;

            bool yes = int1 == int2;
            bool no = int1 != int2;

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
