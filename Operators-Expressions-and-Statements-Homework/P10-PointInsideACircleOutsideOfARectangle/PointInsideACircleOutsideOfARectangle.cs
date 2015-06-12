using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_PointInsideACircleOutsideOfARectangle
{
    class PointInsideACircleOutsideOfARectangle
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double h = 1;
            double k = 1;
            double r = 1.5;

            if (((x - h) * (x - h) + (y - k) * (y - k)) <= (r * r))
            {
                
                if (((x > 5) || (x < -1) || (y > 1) || (y < -1)))
	            {
                    Console.WriteLine(true); 
	            }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
