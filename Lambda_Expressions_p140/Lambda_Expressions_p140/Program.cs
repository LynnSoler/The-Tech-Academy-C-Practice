using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions_p140
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJ CREATION
            List<Employee> list = new List<Employee>(); 

            //CREATE LIST W/ => 10 EMPLOYEES W/ FNAME, LNAME, ID, and 2 EMP W/ FNAME = "JOE"
            list.Add(new Employee { FirstName = "Margot", LastName = "Robbie", Id = 5001 });
            list.Add(new Employee { FirstName = "Steve", LastName = "Martin", Id = 5002 });
            list.Add(new Employee { FirstName = "Katherine", LastName = "Pierce", Id = 5003 });
            list.Add(new Employee { FirstName = "Homer", LastName = "Simpson", Id = 5004 });
            list.Add(new Employee { FirstName = "Joe", LastName = "Rogers", Id = 5005 });
            list.Add(new Employee { FirstName = "Ellen", LastName = "Degeneres", Id = 5006 });
            list.Add(new Employee { FirstName = "Joe", LastName = "Smith", Id = 5007 });
            list.Add(new Employee { FirstName = "Jennifer", LastName = "Aniston", Id = 5008 });
            list.Add(new Employee { FirstName = "Bo", LastName = "Peep", Id = 5009 });
            list.Add(new Employee { FirstName = "Tim", LastName = "Taylor", Id = 5010 });

        
            //OBJ CREATION
            List<Employee> joe = new List<Employee>(); 

            //USE FOREACH LOOP TO CREATE LIST OF EMPLOYEES W/ FNAME = "JOE"
            foreach (Employee name in list)
            {
                if (name.FirstName == "Joe")
                {
                    joe.Add(new Employee { FirstName = name.FirstName, LastName = name.LastName, Id = name.Id });
                }
            }

            foreach (Employee name in joe)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName + " " + name.Id);
            }

            //Console.Read();  DEBUG PASS, DISPLAYS 2 "JOE" EMP'S
            //...


            //LAMBDA EXPRESSION TO PERFORM SAME FUNCTION AS ABOVE
            List<Employee> joeLambda = list.Where(n => n.FirstName == "Joe").ToList();

            foreach (Employee name in joeLambda)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName + " " + name.Id);
            }


            //LAMBDA EXPRESSION TO CREATE EMP LIST W/ ID > 5
            List<Employee> greaterThan = list.Where(x => x.Id > 5).ToList();
            
            foreach (Employee name in greaterThan)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName + " " + name.Id);
            }

            Console.Read();
        }
    }
}
