using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_DistanceCalculator
{
    class ProgramMain
    {
        public static void Main(string[] args)
        {
            Point3D pointOne = new Point3D(-7, -4, 3);
            Point3D pointTwo = new Point3D(17, 6, 2.5);

            Console.WriteLine(DistanceCalculator.CalculateDistance(pointOne, pointTwo));
        }
    }
}
