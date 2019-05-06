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

            Person person = new Person();
            person.FirstName.Add("Sample");
            person.LastName.Add("Student");
            person.SayName();
            Console.ReadLine();

        }
    }
}
