using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Employee_Data
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            String firstName = "Amanda";
            String lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            long personalId = 8306112507;
            int unigueEmployeeNumber = 27563571;


            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalId);
            Console.WriteLine("Unique Employee number: {0}", unigueEmployeeNumber);

        }
    }
}
