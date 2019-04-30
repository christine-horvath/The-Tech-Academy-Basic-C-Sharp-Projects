using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Program
{
    public class Result
    {
        public Result()
        { //add userInput to a fourth list as the program runs through the loop.
            StoredValue = new List<StoredValues>();
            List<int> Numberone = new List<int>() { 5, 6, 9 };
           
            foreach (int number in Numberone)
            {
                StoredValues storedvalue = new StoredValues();
                storedvalue.NumberOne = number;
                StoredValue.Add(storedvalue);
            }

        }
        public List<StoredValues> StoredValue { get; set; }
    }
}
