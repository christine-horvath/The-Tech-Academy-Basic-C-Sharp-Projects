using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    class Program
    {
        //4. Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student".
        //5. Call the superclass method SayName() on the Employee object.
        static void Main(string[] args)
        {
            
            Employee<string> item = new Employee<string>();
            Employee<int> itemA = new Employee<int>();
            item.Things = new List<string>() { "puppies", "pebbles", "polar bears", "please" };
            itemA.Things = new List<int>() { 33, 21, 43, 9 };

            foreach (string thing in item.Things)
            {
                foreach (int thingA in itemA.Things)
                {
                    Console.WriteLine(thing + thingA);

                }
            }
            
            Console.ReadLine();

            //Employee employee = new Employee();
            //Employee employee1 = new Employee();
            //employee.Id = 4;
            //employee1.Id = 3;
            //if (employee.Id == employee1.Id)
            //{
            //    Console.WriteLine("The Employee ID's are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("The Employee ID's are not the same.");
            //}
            //Console.ReadLine();
            

            //Employee quit = new Employee();
            //quit.FirstName = new List<string>() { "Sample" };
            //quit.LastName = new List<string>() { "Student" };
            //quit.SayName();
            //quit.Quit(quit);
            //Console.ReadLine();

            //Employee person = new Employee();
            //person.FirstName = new List<string>() { "Sample" };
            //person.LastName = new List<string>() { "Student" };
            //person.SayName();
            //Console.ReadLine();


        }
    }
}
