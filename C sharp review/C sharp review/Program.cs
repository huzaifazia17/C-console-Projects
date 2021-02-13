
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//           PSUEDOCODE
// Start
//      Set num = 0 
//      Start do while loop iwhen num >10 or num is <1 
//      Cask user to enter a number
//      start a try and catch statment when a letter is entered
//      ask user to reenter the number if exception caught
//      if number between 1 and 10 is entered then display thanks
//End

namespace C_sharp_review
{
    class Program
    {
        static void Main(string[] args)
        {
            //change title
            Console.Title = "C# Review- Loop";
            //change text colour
            Console.ForegroundColor = ConsoleColor.Red;
            
            // set num to 0
            int num = 0;
 
           do
            {
                //ask user to enter a number
                Console.Write("Please enter a number between 1 and 10: ");
                try
                {
                    //convert num to a 32 bit integer
                    num = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch (Exception e)
                {
                    //display incorect
                    Console.Write("Incorrect: ");
                }
                //while condition
            } while (num > 10 || num < 1);


                //display thanks message
                Console.WriteLine("Thanks");

            //keeps console window open
            Console.ReadKey();
        }
    }
}
