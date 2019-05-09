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

            DateTime currentTime = DateTime.Now;            
            Console.WriteLine(DateTime.Now);
            //Console.ReadLine();
            Console.WriteLine("Please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime plusUserInputHours = currentTime.AddHours(userInput);
            Console.WriteLine("In " + userInput + " hours, the time will be " + string.Format("{0}", plusUserInputHours + "."));
            Console.ReadLine();


        }
    }
}
