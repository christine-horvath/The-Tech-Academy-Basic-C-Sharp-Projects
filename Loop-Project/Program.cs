using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Do a boolean comparison using a while statement.
            //2.Do a boolean comparison using a do while statement.

            //Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool guessResult = number == 616;

            //while (!guessResult)
            //{
            //    switch (number)
            //    {
            //        case 444:
            //            Console.WriteLine("You guessed 444. That is not correct; try again.");
            //            Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 847:
            //            Console.WriteLine("You guessed 847. That is not correct; try again.");
            //            Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 606:
            //            Console.WriteLine("You guessed 606. That is not correct; try again.");
            //            Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 616:
            //            Console.WriteLine("You are correct!");
            //            guessResult = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are incorrect. Try again.");
            //            Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }                
            //}
            //Console.Read();

            Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessResult = number == 616;

            do
            {
                switch (number)
                {
                    case 444:
                        Console.WriteLine("You guessed 444. That is not correct; try again.");
                        Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 847:
                        Console.WriteLine("You guessed 847. That is not correct; try again.");
                        Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 606:
                        Console.WriteLine("You guessed 606. That is not correct; try again.");
                        Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 616:
                        Console.WriteLine("You are correct!");
                        guessResult = true;
                        break;
                    default:
                        Console.WriteLine("You are incorrect. Try again.");
                        Console.WriteLine("Without using a calculator, what is the result of 14 times 44?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!guessResult);

            Console.Read();

        }
    }
}
