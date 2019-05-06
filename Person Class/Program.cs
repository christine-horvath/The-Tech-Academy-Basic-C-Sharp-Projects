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
            Employee quit = new Employee();
            quit.FirstName = new List<string>() { "Sample" };
            quit.LastName = new List<string>() { "Student" };
            quit.SayName();
            quit.Quit(quit);
            Console.ReadLine();

            //Employee person = new Employee();
            //person.FirstName = new List<string>() { "Sample" };
            //person.LastName = new List<string>() { "Student" };
            //person.SayName();
            //Console.ReadLine();


        }
    }
}
