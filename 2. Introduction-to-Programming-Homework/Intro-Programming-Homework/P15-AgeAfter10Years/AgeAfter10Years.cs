using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            int currentDate = int.Parse(DateTime.Now.ToString("yyyy"));
            int yearOfBirth, currentAge;
            String dateOfBirth;


            Console.Write("Enter your date of birth: ");
            dateOfBirth = Console.ReadLine();
            yearOfBirth = int.Parse(dateOfBirth.Split('.')[2]);

            currentAge = currentDate - yearOfBirth;

            Console.WriteLine("Now: {0}", currentAge);
            Console.WriteLine("After 10 years: {0}", currentAge + 10);
        }
    }
}
