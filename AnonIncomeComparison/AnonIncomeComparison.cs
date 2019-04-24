using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonIncomeComparison
{
    class AnonIncomeComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is Person 1's hourly rate?");
            decimal paHourly = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How many hours does Person 1 work per week?");
            int paHours = Convert.ToInt32(Console.ReadLine());
            decimal paAnnual = (paHourly * paHours * 52);
            Console.WriteLine("Person 2:");
            Console.WriteLine("What is Person 2's hourly rate?");
            decimal pbHourly = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How many hours does Person 2 work per week?");
            int pbHours = Convert.ToInt32(Console.ReadLine());
            decimal pbAnnual = (pbHourly * pbHours * 52);
            Console.WriteLine("Annual Salary of Person 1");
            Console.WriteLine(paAnnual);
            Console.WriteLine("Annual Salary of Person 2");
            Console.WriteLine(pbAnnual);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool annualSalary = paAnnual > pbAnnual;
            Console.WriteLine(annualSalary);
            Console.ReadLine();
        }
    }
}
