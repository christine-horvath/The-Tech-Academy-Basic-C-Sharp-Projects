using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class CarInsuranceProgram
    {
        static void Main(string[] args)
        {

            //What is your age ?

            //Have you ever had a DUI?

            //How many speeding tickets do you have?

            //Use the following qualification rules to determine if the applicant qualifies for car insurance:

            //Applicants must be over 15 years old.

            //Applicants must not have any DUI’s.

            //Applicants must not have more than 3 speeding tickets.

            //Print the result of the boolean expression created from the above business rules.


            Console.WriteLine("What is your age?");
            int enterAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? 'true or false'.");
            string hasDui = Console.ReadLine();
            bool dui = true;

            Console.WriteLine("How many speeding tickets do you have?");
            int hasTickets = int.Parse(Console.ReadLine());
          
            Console.WriteLine("Does applicant qualify for car insurance?");
            bool result = (enterAge > 15 && dui && hasTickets <3);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
