using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_p131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> vaccine = new Employee<string>(); //INITIATE EMP OBJ W/STRING AS GEN PARAMETER
            vaccine.vaccine2 = new List<string>() { "flu", "tb", "swine", "pox" }; //ASSIGN LIST OF STRINGS AS PROP VAL OF "THINGS"

            foreach (string item in vaccine.vaccine2) //CREATE LOOP TO PRINT ALL THINGS TO CONSOLE
            {
                Console.WriteLine(item); //CREATE LOOP TO PRINT ALL THINGS TO CONSOLE
            }

            Employee<int> number = new Employee<int>(); //INITIATE EMP OBJ W/INT AS GEN PARAMETER
            number.vaccine2 = new List<int>() { 100, 50, 75, 200 }; //ASSIGN LIST OF INTEGERS AS PROP VAL OF "THINGS"

            foreach (int num in number.vaccine2) //CREATE LOOP TO PRINT ALL THINGS TO CONSOLE
            {
                Console.WriteLine(num); //CREATE LOOP TO PRINT ALL THINGS TO CONSOLE
            }

            Console.ReadLine();
        }
    }
}
