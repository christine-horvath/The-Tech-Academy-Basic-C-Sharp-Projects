using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill
{
    public class Combo
    {
        public Combo()
        {
            RetiredJerseys = new List<NewClass>();
            List<int> Jerseys = new List<int>() { 27, 54, 8, 16, 12 };
            List<int> Years = new List<int>() { 1998, 1985, 2011, 2018, 2019 };

            foreach (int year in Years)
            {
                foreach (int jersey in Jerseys)
                {
                    NewClass newclass = new NewClass();
                    newclass.Jersey = jersey;
                    newclass.YearRetired = year;
                    RetiredJerseys.Add(newclass);
                }
            }
        }
        public List<NewClass> RetiredJerseys { get; set; }
                
            
    }
}