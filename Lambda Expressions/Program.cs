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
            //var newList = new List<Class1>();
            //newList.Add(new Class1 { FirstName = "hello", LastName = "horvath",  EmployeeID = 1 });
            //Console.WriteLine(newList[0]);
            //Console.ReadLine();


            //var list = new[FirstName, LastName, EmployeeID]
            //{
            //new { FirstName = "Joe", LastName = "Lyons", EmployeeID = 1 },
            //new { FirstName = "Dan", LastName = "Luthern", EmployeeID = 2 },
            //new { FirstName = "Joe", LastName = "Eagle", EmployeeID = 3 },
            //new { FirstName = "Gertrude", LastName = "Lewis", EmployeeID = 4 },
            //new { FirstName = "Petunia", LastName = "Ward", EmployeeID = 5 },
            //new { FirstName = "Griffin", LastName = "Danger", EmployeeID = 6 },
            //new { FirstName = "Christine", LastName = "Horvath", EmployeeID = 7 },
            //new { FirstName = "Mike", LastName = "LaRocca", EmployeeID = 8 },
            //new { FirstName = "Lula", LastName = "Dogue", EmployeeID = 9 },
            //new { FirstName = "Lucas", LastName = "Lyons", EmployeeID = 10 }
            //};
            //    Console.WriteLine(list);
            //    Console.ReadLine();

            //List<string> FirstName = new List<string>() { "Joe", "Dan", "Joe", "Gertrude", "Petunia", "Griffin", "Christine", "Mike", "Lula", "Lucas"};
            //List<string> LastName = new List<string>() { "Lyons", "Luthern", "Eagle", "Lewis", "Ward", "Danger", "Fumi", "LaRocca", "Dogue", "Horvath" };
            //List<int> EmployeeId = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //List<string> Employees = new List<string>();
            //foreach (string name in FirstName)
            //{
            //    foreach (string lname in LastName)
            //    {
            //        foreach (int ID in EmployeeId)
            //        {
            //            Employees.Add(name, lname, ID);
            //        }
            //    }
            //}

            //List<int> newList= EmployeeId.Where(x => x > 5).ToList();
            //Console.WriteLine(newList);
            //Console.ReadLine();

            //int count = FirstName.Count(x => x == "Joe");
            //Console.WriteLine(count);
            //Console.ReadLine();

            //int counter = 0;
            //foreach (string firstname in FirstName)
            //{
            //    if (firstname == "Joe")
            //    {
            //        counter++;
            //    }

            //};
            //Console.WriteLine(counter);
            //Console.ReadLine();

            var list = new List<Tuple<string, string, int>>();
            {
                list.Add(new Tuple<string, string, int>("Joe", "Lyons", 1));
                list.Add(new Tuple<string, string, int>("Dan", "Luthern", 2));
                list.Add(new Tuple<string, string, int>("Joe", "Eagle", 3));
                list.Add(new Tuple<string, string, int>("Gertrude", "Lewis", 4));
                list.Add(new Tuple<string, string, int>("Petunia", "Ward", 5));
                list.Add(new Tuple<string, string, int>("Griffin", "Miller", 6));
                list.Add(new Tuple<string, string, int>("Christine", "Horvath", 7));
                list.Add(new Tuple<string, string, int>("Lucas", "Horvath", 8));
                list.Add(new Tuple<string, string, int>("Lula", "Fumi", 9));
                list.Add(new Tuple<string, string, int>("Mike", "LaRocca", 10));
            }
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var newList = new List<Tuple<string, string, int>>(); list.Where(x => x > 5).ToList();

            //foreach (var element in list)
            //{
            //    {
            //        Console.WriteLine(int i > 5);
            //    }
            //}
            Console.ReadLine();




        }

    }
}
