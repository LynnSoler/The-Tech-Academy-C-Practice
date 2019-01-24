using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Iterations_p103
{
    class Program
    {
        static void Main(string[] args)
        {
            //1D ARRAY OF STRINGS
            string[] names1 = new string[5];
            Console.WriteLine("Please type in 4 names");
            for (int i = 0; i < names1.Length; i++)
            {
                names1[i] = Console.ReadLine();
                Console.WriteLine(names1[i]);
            }

            Console.ReadLine();

            //CREATE INFINITE LOOP
            int days = 30;
            for (int i = 0; i != days; i += 4)
            {
                Console.WriteLine($"Days Counted: {i}");
                Console.WriteLine($"Days Left: {days - i}");
            }

            //FIX INFINITE LOOP
            int days1 = 30;
            for (int i = 0; i <= days1; i++)
            {
                Console.WriteLine($"Days Counted: {i}");
                Console.WriteLine($"Days Left: {days1 - i}");
            }

            //LOOP WITH "<" OPERATOR
            int[] ranNums = { 500, 200, 1000, 8000, 5, 40, 265 };
            for (int i = 0; i < ranNums.Length; i++)
            {
                Console.WriteLine(ranNums[i]);
            }

            Console.ReadLine();

            //LOOP WITH "<=" OPERATOR
            int[] birthdays = { 12, 13, 27, 3, 30, 31 };
            for (int j = 0; j<= birthdays.Length - 1; j++)
            {
                Console.WriteLine(birthdays[j]);
            }

            Console.ReadLine();

            //LIST OF STRINGS..
            //LOOP TO ITERATE THRU LIST & DISPLAY COORDINATING INDEX OF ARRAY
            List<string> names2 = new List<string>() { "Ryan", "Michelle", "Tommy", "Sebastian", "Sam" };
            Console.WriteLine("Choose a name to display the index for your chosen name in the array.");
            string _name = Console.ReadLine();

            if (!names2.Contains(_name))
            {
                Console.WriteLine("Error. This name does not exist."); //DNE MSSG
            }
            else
            {
                foreach (string name in names2)
                {
                    if (_name == name)
                    {
                        Console.WriteLine(names2.IndexOf(name));
                    }
                }
            }

            Console.ReadLine();

            //LOOP TO ITERATE THRU LIST & DISPLAY COORDINATING INDICES OF ARRAY
            List<string> counties = new List<string>() { "Arapahoe", "Douglas", "Jefferson" };
            Console.WriteLine("Choose a county to display the index for your chosen county in the array.");
            string _county = Console.ReadLine();
            int index = 0;
            
            if (!counties.Contains(_county))
            {
                Console.WriteLine("Error. This county does not exist.");
            }
            else
            {
                for (int i = 0; i < counties.Count; i++)
                {
                    index = i;
                    if (_county == counties[i])
                    {
                        Console.WriteLine(counties[i] + " at index of " + index);
                    }
                }

                Console.ReadLine();
            }

            //LIST OF STRINGS WITH AT LEAST 2 IDENTICAL STRINGS
            List<string> presidents = new List<string>() { "Lincoln", "Jefferson", "Trump", "Reagan", "Obama" };
            Console.WriteLine("Choose a President name to see if it's in this list, otherwise your chosen name will be added.");
            string _president = Console.ReadLine();

            if (!presidents.Contains(_president))
            {
                presidents.Add(_president);
                Console.WriteLine("Error. This President name does not exist; it will be added to the list now."); //DNE MSSG
            }
            else
            {
                foreach (string president in presidents) //FOREACH LOOP TO EVALUATE ITEMS IN LIST
                {
                    if (_president == president)
                    {
                        Console.WriteLine("Error. This President name already exists."); //DUPLICATE MSSG
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
