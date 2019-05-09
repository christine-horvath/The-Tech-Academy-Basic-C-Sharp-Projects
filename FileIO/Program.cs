using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ask a user for a number.
            //2.Log that number to a text file.
            //3.Print the text file back to the user.
            //Console.WriteLine("Please enter a number.");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //string text = userInput.ToString();
            //File.WriteAllText(@"C:\Users\Christine.Horvath\logs\log.txt", text);
            //Console.Write("The number you entered is " + (File.ReadAllText(@"C:\Users\Christine.Horvath\logs\log.txt") + "."));
            //Console.Write(File.ReadAllText(@"C:\Users\Christine.Horvath\logs\log.txt"));
            //Console.ReadLine();

            //DateTime currentTime = DateTime.Now;            
            //Console.WriteLine(DateTime.Now);
            ////Console.ReadLine();
            //Console.WriteLine("Please enter a number.");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //DateTime plusUserInputHours = currentTime.AddHours(userInput);
            //Console.WriteLine("In " + userInput + " hours, the time will be " + string.Format("{0}", plusUserInputHours + "."));
            //Console.ReadLine();

            //1.Create a const variable
            //2.Create a variable using the keyword "var".
            //3.Chain two constructors together. - in DogNutrition class

            //const string lulasFood = "Blue Buffalo Freedom";
            //var lulasTreats = "Dentasticks";

            //1.Ask the user for his age.
            //2.Display the year user born.
            //3.Exceptions must be handled using "try .. catch".
            //4.Display appropriate error messages if user enters zero or negative numbers.
            //5.Display a general message if exception caused by anything else.
            //strings, i <= 0, anything else. 

            DateTime currentTime = DateTime.Now;

            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                Console.WriteLine("Please enter your age");
                //casts from string to int - if it doesnt succeed, bet = 0
                validAnswer = int.TryParse(Console.ReadLine(), out age);
                if (!validAnswer)
                {
                    Console.WriteLine("Please enter positive integers ONLY, no decimals or letters.");
                    Console.ReadLine();
                    return;
                }
                else if (age <= 0)
                {
                    Console.WriteLine("Please enter positive integers only, no decimals or letters." );
                    Console.ReadLine();
                    return;
                }
                else
                {
                    DateTime yearBorn = currentTime.AddYears(-age);
                    Console.WriteLine("Based on your age you must have been born in " + yearBorn.Year + ".");
                    Console.ReadLine();
                }

            }
        }
    }
}



           




            
        


        


