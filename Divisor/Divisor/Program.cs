using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Psuedocode
//START
// create varaiables
// ask user to enter number
// for loop and if statement for the divisors
// Modulus divide the input to get divisors
//display divisors
//END

namespace Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your Divisors are.. ");
                    for (int i = 1; i <= input; i++)
                    {
                        //modulus divison to find divisors
                        if (input % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                catch (Exception)
                {
                    //display incorect
                    Console.Write("Please enter a real number: ");
                }
            }
       
            Console.ReadKey();
        }
    }
}
