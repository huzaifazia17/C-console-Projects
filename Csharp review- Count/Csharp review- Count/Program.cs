using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PSUEDOCODE 
//START
// get variable for the word stop, input word and counter
// start while loop for if input does not equal to stop
// inside while loop ask for user ti enter word, convert word to lower case
// count the number wof words with counter
//start if statment for is input equals to stop
//display number of words entered
//END

namespace Csharp_review__Count
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variables
            string word = "stop";
            string input = "";
            int counter = 0;

            //start while loop
            while (input != word )
            {
                //ask user to enter a word
                Console.Write("PLease enter a word: ");
                //read word
                input = Console.ReadLine();
                //shift word to lower case
                string lower = input.ToLower();
                //counter 
                counter++;

                //start if statemnet 
                if (lower == word)
                {
                    // tell users how many words entered
                    Console.WriteLine("You entered: " + (counter - 1) + " words");
                    // breakk program
                    break;
                }
            }

            //keep console window open
            Console.ReadKey();

        }
    }
}
