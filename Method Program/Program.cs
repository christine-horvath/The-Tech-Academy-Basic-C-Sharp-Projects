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
           int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = 9;
            int number3 = 8;
            int number4 = 17;

            StoredValues ob = new StoredValues();

            int Monkey1 = ob.Monkey(number1, number2);
            Console.WriteLine("The sum of your number + 9 is " + Monkey1);
            int Monkey2 = ob.Monkey(number1, number2, number3);
            Console.WriteLine("The sum of your number + 9 + 8 is " + Monkey2);
            int Monkey3 = ob.Monkey(number1, number2, number3, number4);
            Console.WriteLine("The sum of your number + 9 + 8 + 17 is " + Monkey3);
            Console.ReadLine();
        }
    }
}
