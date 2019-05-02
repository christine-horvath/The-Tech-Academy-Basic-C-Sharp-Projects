using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_App
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter an Odd Number");
            //int cream = Convert.ToInt32(Console.ReadLine());
            //int sugar = 2;

            //Lattes latte = new Lattes();
            //latte.AlmondMilk(cream, sugar);
            //Console.WriteLine("Your total of creams plus sugars is " + latte.AlmondMilk(cream, sugar));
            //Console.ReadLine();

            ////////////////////////////////////////////////////

            //Console.WriteLine("Enter a decimal");
            //double cream = Convert.ToDouble(Console.ReadLine());
            //double sugar = 2;
            //double syrup = 5;

            ////Lattes latte = new Lattes();
            ////latte.AlmondMilk(cream, sugar);
            ////Console.WriteLine("Your total of creams plus sugars is " + latte.AlmondMilk(cream, sugar));
            ////Console.ReadLine();

            //Lattes latte = new Lattes();
            //latte.AlmondMilk(cream, syrup, sugar);
            //Console.WriteLine(Convert.ToInt64(latte.AlmondMilk(cream, syrup, sugar)));
            //Console.ReadLine();

            //////////////////////////////////////////////////////
            
            Console.WriteLine("Enter a number");
            string cream = (Console.ReadLine());
            string sugar = "sugars";

            Lattes latte = new Lattes();
            latte.AlmondMilk(cream, sugar);
            Console.WriteLine("Your number plus the string = " + (Convert.ToInt64(latte.AlmondMilk(cream, sugar))));
            Console.ReadLine();

        }
    }
}
