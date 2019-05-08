using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Lambda_Expressions
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<Employee> myEmployeeList = new List<Employee>();
            
            myEmployeeList.Add(new Employee { FirstName = "Joe", LastName = "Lyons", EmployeeID = 1 });
            myEmployeeList.Add(new Employee { FirstName = "Dan", LastName = "Luthern", EmployeeID = 2 });
            myEmployeeList.Add(new Employee { FirstName = "Joe", LastName = "Eagle", EmployeeID = 3 });
            myEmployeeList.Add(new Employee { FirstName = "Christine", LastName = "Horvath", EmployeeID = 5 });
            myEmployeeList.Add(new Employee { FirstName = "Griffin", LastName = "Browning", EmployeeID = 6 });
            myEmployeeList.Add(new Employee { FirstName = "Mike", LastName = "Sikora", EmployeeID = 7 });
            myEmployeeList.Add(new Employee { FirstName = "Joe", LastName = "Brown", EmployeeID = 8 });
            myEmployeeList.Add(new Employee { FirstName = "Lula", LastName = "Horvath", EmployeeID = 9 });
            myEmployeeList.Add(new Employee { FirstName = "Lucas", LastName = "Horvath", EmployeeID = 10 });

            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".
            List < Employee > newList = new List<Employee>();
            foreach (var person in myEmployeeList)
            {
                if (person.FirstName == "Joe")
                {
                    newList.Add(person);
                    Console.WriteLine(person.FirstName + " " + person.LastName);
                }
            }
            Console.ReadLine();


            //3.Do the same thing again, but this time with a lambda expression.
            //new List<Employee> (myEmployeeList.Where(x => x.FirstName == "Joe").ToList()).ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));

            //Console.ReadLine();


            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.
            //new List<Employee> (myEmployeeList.Where(x => x.EmployeeID > 5).ToList()).ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));

            // Console.ReadLine();

        }

    }
}
