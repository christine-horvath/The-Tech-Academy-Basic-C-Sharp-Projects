using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class First
    {
        public First()
        {

        }
        //create the method 
        //user enter a number, call the method on that number
        //display the output to the screen. it should be the entered number, divided by 2

        public void FirstClass(out int x, int y)
        {
            x = y / 2;
        }

        public void newMethod(out int varA, out int varB)
        {
            varA = Convert.ToInt32(Console.ReadLine());
            varB= Convert.ToInt32(Console.ReadLine());
        }
        public void assignValues(out double varA, out double varB)
        {
            varA = Convert.ToDouble(Console.ReadLine());
            varB = Convert.ToDouble(Console.ReadLine());
        }
    }

}

