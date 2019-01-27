using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_WhileLoops_p94
{
    class Program
    {
        static void Main()
        {
            //WHILE LOOP
            Console.WriteLine("Can you guess my favorite color?");
            string guess = Console.ReadLine();
            bool colorGuessed = guess == "green";

            while (!colorGuessed)
            {
                switch (guess)
                {
                    case "green":
                        Console.WriteLine("YES! That's my favorite color!");
                        colorGuessed = true;
                        break;

                    default:
                        Console.WriteLine("No, that's not my favorite color.. To give you some help, it's a color commonly seen outdoors..");
                        Console.WriteLine("Can you guess my favorite color?");
                        guess = Console.ReadLine();
                        break;
                }
            }
            //DO WHILE LOOP
            Console.WriteLine("Guess a color");
            string guessRand = Console.ReadLine();
            bool colorRand = guessRand == "orange";

            do
            {
                switch (guess)
                {
                    case "orange":
                        Console.WriteLine("Wow! You guessed it!");
                        colorRand = true;
                        break;

                    default:
                        Console.WriteLine("Sorry, try again!");
                        Console.WriteLine("..Guess a color");
                        guessRand = Console.ReadLine();
                        break;
                }
            }

            while (colorRand);

            Console.ReadLine();
        }
    }
}
