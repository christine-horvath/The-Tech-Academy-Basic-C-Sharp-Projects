using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_App
{
    public class Lattes
    {
        public int AlmondMilk(int cream, int sugar)
        {
            int AlmondMilk = (cream) - (sugar);
            return AlmondMilk;
        }

        public double AlmondMilk(double cream, double syrup, double sugar)
        {
            double AlmondMilk = cream * syrup * sugar;
            return AlmondMilk;

        }

        public string AlmondMilk(string cream, string sugar)
        {
            string AlmondMilk = (cream) + (sugar);

            {
                if (Int32.TryParse(AlmondMilk, out int numValue))
                {
                    return AlmondMilk;
                }
                else

                    Console.WriteLine($"Int32.TryParse could not parse the following to an integer: " + AlmondMilk);

            }
            return AlmondMilk;
        }
    }
}