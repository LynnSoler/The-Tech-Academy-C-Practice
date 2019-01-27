using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_p126
{
    class Program
    {
        static void Main(string[] args)
        {
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
