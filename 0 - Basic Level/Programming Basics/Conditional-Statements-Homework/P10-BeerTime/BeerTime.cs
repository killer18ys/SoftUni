using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string time = input.Split(' ')[0];
            string AmPm = input.Split(' ')[1];

            int hours = int.Parse(time.Split(':')[0]);
            int minutes = int.Parse(time.Split(':')[1]);

            Console.WriteLine("<-----Test----->");
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.WriteLine(AmPm);
            Console.WriteLine("<-----Test----->");


            if (hours >= 1 && hours < 12 && AmPm == "PM")
            {
                if (hours == 1 && minutes != 0)
                {
                    Console.WriteLine("Non-Beer Time"); 
                }
                else
                {
                    Console.WriteLine("Beer Time");
                }
            }
            else if (hours >= 1 && hours < 3 && AmPm == "AM")
            {
                if (hours == 3 && minutes != 0)
                {
                    Console.WriteLine("Non-Beer Time");
                }
                else
                {
                    Console.WriteLine("Beer Time");
                }
            }
            else if (hours < 1 || hours > 12 || minutes < 0 || minutes > 59 || (AmPm != "AM" || AmPm != "PM" ))
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                Console.WriteLine("Non-Beer Time");
            }
        }
    }
}
