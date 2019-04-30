using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Program
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter an integer");
           int UserInput = Convert.ToInt32(Console.ReadLine());
 
           Result result = new Result();

           Console.WriteLine("Your number + values from list one");

            foreach (StoredValues storedvalues in result.StoredValue)
                 {
                
                     Console.WriteLine(UserInput + storedvalues.NumberOne);

                 }

            Console.WriteLine("Your number * values from list one");

            foreach (StoredValues storedvalues in result.StoredValue)
                 {  
                       Console.WriteLine(UserInput * storedvalues.NumberOne);
                 }

            Console.WriteLine("Your number / values from list one");

            foreach (StoredValues storedvalues in result.StoredValue)
                 {
                     Console.WriteLine(UserInput / storedvalues.NumberOne);
                 }
            Console.ReadLine();
        }
    }
}
