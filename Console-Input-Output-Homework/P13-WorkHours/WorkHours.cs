using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            int hoursToFinish = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            percent = percent / 100;

            double daysToWork = days * 12 * 0.9;

            double diff = Math.Floor((daysToWork * percent) - hoursToFinish);


            if (diff < 0)
            {
                Console.WriteLine("No");
                Console.WriteLine(diff);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine(diff);
            }

            

        }
    }
}
