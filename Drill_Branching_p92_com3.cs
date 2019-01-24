using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Branching_p92
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greet
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //PKG Weight
            Console.WriteLine("In pounds, how much does your package weigh?");
            double pkgWeight = Convert.ToDouble(Console.ReadLine());
                if (pkgWeight > 50)
                {
                    Console.WriteLine("Package is too heavy to be shipped by Package Express. Have a great day.");
                    Console.ReadLine();
                    Environment.Exit(1);
                }

            //PKG Dimensions
            Console.WriteLine("In inches, what is the Length of your package?");
            double pkgLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In inches, what is the Width of your package?");
            double pkgWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In inches, what is the Height of your package?");
            double pkgHeight = Convert.ToDouble(Console.ReadLine());

            double pkgDimensions = (pkgLength + pkgWidth + pkgHeight);
                if (pkgDimensions > 50)
                {
                    Console.WriteLine("Package is too big to be shipped by Package Express. Have a great day.");
                    Console.ReadLine();
                    Environment.Exit(1);
                }

            double shipTotal = (pkgDimensions * pkgWeight) / 100;

            Console.WriteLine("Your estimated total for shipping your package is $" + shipTotal);
            Console.ReadLine();

        }
    }
}
