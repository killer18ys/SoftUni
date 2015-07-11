using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_StudentCables
{
    class StudentCables 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string measure;
            double value;
            double cableLenght = 0;
            double unusedCable;
            int cables;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                value = double.Parse(Console.ReadLine());
                measure = Console.ReadLine();

                if (measure == "meters")
                {
                    cableLenght += value * 100;
                }
                else
                {
                    if (value < 20)
                    {
                        count++;
                        continue;
                    }

                    cableLenght += value;
                }
            }

            cableLenght = cableLenght - ((((n - count) * 2) - 2) * 1.5);

            unusedCable = cableLenght % 504;
            cables = (int)cableLenght / 504;

            Console.WriteLine(cables);
            Console.WriteLine(unusedCable);
        }
    }
}
