using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Point3D
{
    class ProgramMain
    {
        public static void Main(string[] args)
        {
            Point3D p1 = new Point3D(3, 7, 13);

            Console.Write("Starting point - ");
            Console.WriteLine(Point3D.GetStartingPoint);
            Console.Write("Current point - ");
            Console.WriteLine(p1);
            
        }
    }
}
