using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_Comparing_Floats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            //double eps = Double.Epsilon;
            double eps = 0.000001;
            double v1 = -4.999999;
            double v2 = -4.999998;

            bool isEqual = (Math.Max(v1, v2) - Math.Min(v1, v2)) < eps ? true : false;


            Console.WriteLine(isEqual);

        }
    }
}
