using System;
using System.Collections.Generic;
using System.IO; //***NEEDED TO ADD "SYSTEM.IO" FOR COMPILER TO RECOGNIZE NAMESPACE OUTSIDE OF CURRENT CONTEXT/TARGET: File_IO_p154 ;-)
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_p154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that will be logged to a .txt file");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Lynn\Documents\GitHub\Tech-Academy-C-Practice\File_IO_p154\Log_Number.txt", text);
            string FileRead = File.ReadAllText(@"C:\Users\Lynn\Documents\GitHub\Tech-Academy-C-Practice\File_IO_p154\Log_Number.txt");
            Console.WriteLine("Number that was logged to Log_Number.txt is: " + " " + FileRead);

            Console.ReadLine();
        }
    }
}
