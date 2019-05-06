using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        public static void Main()
        {
            //ask the user for a number. call the method on that number
            //display the output to the screen. it should be the entered number, divided by 2

            Console.WriteLine("Enter an even number");
            int x = Convert.ToInt32(Console.ReadLine());
            int varA;
            int varB;
            int output;

            First first = new First();
            first.FirstClass(out output, x);
            first.FirstClass(out output, x);
            Console.WriteLine("Your number divided by 2 = " + output);
            Console.WriteLine("Enter two values on the next two lines: ");
            first.newMethod(out varA, out varB);
            Console.WriteLine("Your numbers are: " + varA + "," + varB);

            Console.WriteLine(StaticClass.secondClass());
            Console.Read();
        }  
    

    }
}
