using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_ExamSchedule
{
    class ExamSchedule
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            int durationHour = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());

            int endHour;
            int endMinutes;

            endHour = startHour + durationHour;
            endMinutes = startMinutes + durationMinutes;

            if (endMinutes > 59)
            {
                endMinutes = endMinutes - 60;
                endHour += 1;
            }

            if (endHour > 12)
            {
                endHour = endHour - 12;
                partOfDay = ChangePartOfDay(partOfDay);
            }
            else if (endHour == 12)
            {
                partOfDay = ChangePartOfDay(partOfDay);
            }

            Console.WriteLine("{0:00}:{1:00}:{2}", endHour, endMinutes, partOfDay);

        }

        static string ChangePartOfDay(string partOfDay)
        {
            if (partOfDay == "AM")
            {
                partOfDay = "PM";
            }
            else if (partOfDay == "PM")
	        {
		        partOfDay = "AM";
	        }

            return partOfDay;
        }
    }
}
