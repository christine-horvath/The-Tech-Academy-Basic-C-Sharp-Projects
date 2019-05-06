using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    //3. Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.
    public class Employee : Person, IQuittable
    {
        public List<int> Id { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine("I quit.");
        }
    }
}
