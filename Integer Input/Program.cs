using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Second second = new Second();
            second.Last(second.Num1, second.Num2 = 1);

            Console.WriteLine("Please enter a number:");
            second.Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a number:");
            second.Num2 = 0;
            string input2 = Console.ReadLine();
            if (input2.Equals(string.Empty))
            {
                Console.WriteLine("The sum of your number and the computer's number is: " + second.Last(second.Num1, second.Num2 = 1));
            }
            else
            {
                if (!Int32.TryParse(input2, out second.Num2))
                {
                    Console.WriteLine("Second number was entered incorrectly.");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("The sum of the two numbers is: " + (second.Num1 + second.Num2));
                }
               
            }
            Console.ReadLine();

        
        }

        
    }
    
}

