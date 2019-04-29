using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

        //    List<int> exceptionList = new List<int>();
        //    exceptionList.Add(5);
        //    exceptionList.Add(12);
        //    exceptionList.Add(18);
        //    exceptionList.Add(44);
        //    exceptionList.Add(7);
        //    exceptionList.Add(89);


        //    Console.WriteLine("Please enter a number to divide this list of integers by.");
        //    int userInput = Convert.ToInt32(Console.ReadLine());
           
        //    for (int i = 0; i < exceptionList.Count; i++)
        //    {
        //        Console.WriteLine(exceptionList[i] / userInput);
        //    }


        //    Console.ReadLine();
        //}
        //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.
        //They're right!

        //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.
        //System.DivideByZeroException: 'Attempted to divide by zero.'


        //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.
        //System.FormatException: 'Input string was not in a correct format.'

        //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
//        List<int> exceptionList = new List<int>();
//        exceptionList.Add(5);
//        exceptionList.Add(12);
//        exceptionList.Add(18);
//        exceptionList.Add(44);
//        exceptionList.Add(7);
//        exceptionList.Add(89);
 
//            while(true)
//            { 
//            Console.WriteLine("Please enter a number to divide this list of integers by.");
//            int userInput = Convert.ToInt32(Console.ReadLine());
             
//                try
//                {
//                    for (int i = 0; i < exceptionList.Count; i++)
//                    {
//                        Console.WriteLine(exceptionList[i] / userInput);
//                    }

//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("Please enter an integer.");
//                    return;
//                }
//                catch (DivideByZeroException)
//                {
//                    Console.WriteLine("Please don't divide by zero.");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//                finally
//                {
//                    Console.ReadLine();
//                }
//            }
    
//        }
//    }
//}

