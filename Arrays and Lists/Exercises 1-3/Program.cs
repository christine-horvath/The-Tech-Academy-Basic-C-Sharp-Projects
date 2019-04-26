//using System;
//using System.Collections.Generic;


//class Program
//{
//    static void Main(string[] args)
//    {

        //1.Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
        //string[] chooseArray = new string[4];
        //chooseArray[0] = "It's fun";
        //chooseArray[1] = "to stay";
        //chooseArray[2] = "at the";
        //chooseArray[3] = "YMCA.";

        //Console.WriteLine("Please choose a number 1-4");
        //int number = Convert.ToInt32(Console.ReadLine());
        //bool userInput = number == 0;

        //do
        //{
        //    switch (number)
        //    {
        //        case 1:
        //            Console.WriteLine(chooseArray[0]);
        //            Console.WriteLine("You've revealed the first line of the hidden phrase! Feel free to try again.");
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        case 2:
        //            Console.WriteLine(chooseArray[1]);
        //            Console.WriteLine("You've revealed the second line of the hidden phrase! Feel free to try again.");
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        case 3:
        //            Console.WriteLine(chooseArray[2]);
        //            Console.WriteLine("You've revealed the third line of the hidden phrase! Feel free to try again.");
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        case 4:
        //            Console.WriteLine(chooseArray[3]);
        //            Console.WriteLine("You've revealed the last line of the hidden phrase!");
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        default:
        //            Console.WriteLine("Please choose a number 1-4. Try again.");
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;
        //    }
        //}

        //while (number != 0);
        //Console.ReadLine();

        //2.Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

        //int[] secondArray = {12, 44, 95, 6, 11, 5};
        //Console.WriteLine("Please enter a number 1-6.");
        //int secondNum = Convert.ToInt32(Console.ReadLine());
        //bool secondInput = secondNum == 0;

        //do
        //{
        //    switch (secondNum)
        //    {
        //        case 1:
        //            Console.WriteLine(secondArray[0]);
        //            Console.WriteLine("You've selected index 1! Feel free to try again.");
        //            secondNum = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        case 2:
        //            Console.WriteLine(secondArray[1]);
        //            Console.WriteLine("You've selected index 2! Feel free to try again.");
        //            secondNum = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        case 3:
        //            Console.WriteLine(secondArray[2]);
        //            Console.WriteLine("You've selected index 3! Feel free to try again.");
        //            secondNum = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        case 4:
        //            Console.WriteLine(secondArray[3]);
        //            Console.WriteLine("You've selected index 4! Feel free to try again.");
        //            secondNum = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        case 5:
        //            Console.WriteLine(secondArray[4]);
        //            Console.WriteLine("You've selected index 5! Feel free to try again.");
        //            secondNum = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        case 6:
        //            Console.WriteLine(secondArray[5]);
        //            Console.WriteLine("You've selected index 6! Feel free to try again.");
        //            secondNum = Convert.ToInt32(Console.ReadLine());
        //            break;
        //        default:
        //            Console.WriteLine("Please choose a number 1-6. Try again.");
        //            secondNum = Convert.ToInt32(Console.ReadLine());
        //            break;
        //    }
        //}

        //while (secondNum != 0);
        //Console.ReadLine();


        //3.Add in a message that displays when the user selects an index that doesn’t exist.

        // see default in above exercise