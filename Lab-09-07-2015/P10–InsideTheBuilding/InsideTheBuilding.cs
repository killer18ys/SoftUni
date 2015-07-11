using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_InsideTheBuilding
{
    class InsideTheBuilding 
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int nPoints = 5;

            int[,] points = new int[nPoints, 2];


            for (int i = 0; i < points.GetLength(0); i++)
			{
			     for (int k = 0; k < points.GetLength(1); k++)
			    {
			        points[i,k] = int.Parse(Console.ReadLine());
			    }
			}

            for (int i = 0; i < points.GetLength(0); i++)
            {
                if ((points[i, 1] <= h) && (points[i, 1] >= 0) )
                {
                    if ((points[i, 0] <= 3*h) && (points[i, 0] >= 0))
                    {
                        Console.WriteLine("inside");
                    }
                    else
                    {
                        Console.WriteLine("outside");
                    }
                }
                else if ((points[i, 1] <= 4 * h) && (points[i, 1] >= h))
                {
                    if ((points[i, 0] >= h) && (points[i, 0] <= 2*h))
                    {
                       Console.WriteLine("inside"); 
                    }
                    else
                    {
                        Console.WriteLine("outside");
                    }
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}
