using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();

            DateTime dateOne = DateTime.ParseExact(inputOne, "d.MM.yyyy", CultureInfo.CurrentCulture);
            DateTime dateTwo = DateTime.ParseExact(inputTwo, "d.MM.yyyy", CultureInfo.CurrentCulture);


            System.TimeSpan dateDiff = dateTwo.Subtract(dateOne);

            Console.WriteLine(dateDiff.TotalDays);
        }
    }
}
