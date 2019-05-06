using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    public abstract class Person
    {

        //first name, last name
        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }
        public List<int> Employees { get; set; }

        //1. Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.
        //2. Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]".
        public virtual void SayName()
        {
            foreach (string firstname in FirstName)
            {
                foreach (string lastname in LastName)
                {

                    Console.WriteLine("Name: [" + firstname + " " + lastname + "]");

                }
            }
        }
        public virtual void EmployeeIDs()
        {
            foreach (int employee in Employees)
            {
                Employees.Add(employee);
            }
        }
    }
}
