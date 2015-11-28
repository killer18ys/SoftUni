using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            return Math.Sqrt(Math.Pow((p2.XPoint - p1.XPoint), 2) +
                             Math.Pow((p2.YPoint - p1.YPoint), 2) +
                             Math.Pow((p2.ZPoint - p1.ZPoint), 2));
        }
    }
}
