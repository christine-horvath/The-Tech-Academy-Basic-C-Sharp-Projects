using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”

            //The user must then be prompted for the package weight.

            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.

            //The user must then be prompted for the package width.

            //Then the package height.

            //Then the package length.

            //If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.

            //The sum total of dimensions are then multiplied by the weight and divided by 100.

            //The result of that calculation is the quote.

            //Display the quote to the user as a dollar amount.

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of the package: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have agood day.");
            }
            Console.WriteLine("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            int dimensions = (width + height + length);
            decimal quote = ((dimensions * weight)/100);
            //Console.WriteLine(string s = quote.ToString("C0"));
            Console.WriteLine("The estimated cost for shipping your package is: " + (quote.ToString("C0")));         

            Console.ReadLine();





        }
    }
}
