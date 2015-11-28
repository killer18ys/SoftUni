using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Point3D
{
    public class Point3D
    {
        private static Point3D StartingPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.XPoint = x;
            this.YPoint = y;
            this.ZPoint = z;
        }


        public double XPoint { get; set; }
        public double YPoint { get; set; }
        public double ZPoint { get; set; }

        public static Point3D GetStartingPoint
        {
            get { return Point3D.StartingPoint; }
        }

        public override string ToString()
        {
            return string.Format("Coordinates : ({0}, {1}, {2})", this.XPoint, this.YPoint, this.ZPoint);
        }
    }
}
