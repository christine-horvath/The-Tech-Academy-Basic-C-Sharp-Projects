using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    //3. Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.
    public class Employee<T> //: Person, IQuittable
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }
 

    //public override void SayName()
    //    {
    //        base.SayName();
    //    }

    //    public void Quit(Employee<string> employee)
    //    {
    //        Console.WriteLine("I quit.");
    //    }
        //public static bool operator== (Employee employee, Employee employee1)
        //{
        //    return employee.Id == employee1.Id;
        //}
        //public static bool operator !=(Employee employee, Employee employee1)
        //{
        //    return employee.Id != employee1.Id;
        //}
    }
}
