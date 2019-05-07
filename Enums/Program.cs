using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum daysWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        static void Main(string[] args)
        {
            //1.Create an enum for the days of the week.
            //2. Prompt the user to enter the current day of the week.
            //3. Assign the value to a variable of that enum data type you just created.
            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

            Console.WriteLine("Please enter the current day of the week. Don't forget to capitalize the first letter of the day.");
            string dayString = Console.ReadLine();
            string[] dayStrings = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            foreach (string day in dayStrings)
            {
                try
                {
                    daysWeek dayValue = (daysWeek)Enum.Parse(typeof(daysWeek), dayString);
                    if (Enum.IsDefined(typeof(daysWeek), dayValue) | dayValue.ToString().Contains(","))
                        Console.WriteLine("You entered: " + dayString, dayValue.ToString());
                    else
                        Console.WriteLine("Please enter an actual day of the week.");
                }

                catch (ArgumentException) {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
                Console.ReadLine();
            }


        }
          

        

    }

}
