using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Combo combo = new Combo();
            
            foreach (NewClass newclass in combo.RetiredJerseys)
            {
                Console.WriteLine(newclass.Jersey + " retired in " + newclass.YearRetired);

            }
            Console.WriteLine(combo.RetiredJerseys.Count);
            Console.ReadLine();
        }

    }
}
