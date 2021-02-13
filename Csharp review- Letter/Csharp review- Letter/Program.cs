using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PSUEDOCODE 
//START
// Get variable for letter and input
// Start while loop for if letter is less than a or greater thaz z
// display good job when lowercase letter entered
//END

namespace Csharp_review__Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            char letter = 'A';
            string input = "";

            //start while loop
            while (letter < 'a' || letter > 'z')
            {
                //ask user to enter letter
                Console.Write("Please enter a lowercase letter:" );
                input = Console.ReadLine();
                //convert to char
                letter = Convert.ToChar(input[0]);
            }

            Console.WriteLine("Good Job");


            Console.ReadKey();
        }
    }
}
