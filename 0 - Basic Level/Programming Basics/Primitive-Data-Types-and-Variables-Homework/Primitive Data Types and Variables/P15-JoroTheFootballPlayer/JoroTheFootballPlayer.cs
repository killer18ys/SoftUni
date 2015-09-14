using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            String leapYear = Console.ReadLine();
            int holidaysNum = int.Parse(Console.ReadLine());
            int weeksInHometown = int.Parse(Console.ReadLine());

            double plays = 0;
            int normalWeeks = 52 - weeksInHometown;

            plays += holidaysNum / 2.00;
            plays += weeksInHometown;
            plays += normalWeeks * 2.00 / 3.00;

            if (leapYear == "t")
            {
                plays += 3;
            }

            plays = Math.Round(plays);

            Console.WriteLine(plays);




        }
    }
}
