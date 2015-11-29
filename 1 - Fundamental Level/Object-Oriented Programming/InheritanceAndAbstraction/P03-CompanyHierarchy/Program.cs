using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03_CompanyHierarchy.Models;

namespace P03_CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emploee> listOfEmploees = new List<Emploee>();

            listOfEmploees.Add(new Manager(1, "Stamat1", "Toshev1", 733, Department.Sales));
            listOfEmploees.Add(new Manager(2, "Stamat2", "Toshev2", 333, Department.Production));
            listOfEmploees.Add(new Manager(3, "Stamat3", "Toshev3", 337, Department.Marketing));

            listOfEmploees.Add(new SalesEmployee(1, "Stamat1", "Toshev1", 733, Department.Sales));
            listOfEmploees.Add(new SalesEmployee(2, "Stamat2", "Toshev2", 333, Department.Production));
            listOfEmploees.Add(new SalesEmployee(3, "Stamat3", "Toshev3", 337, Department.Marketing));

            listOfEmploees.Add(new Developer(1, "Stamat1", "Toshev1", 733, Department.Sales));
            listOfEmploees.Add(new Developer(2, "Stamat2", "Toshev2", 333, Department.Production));
            listOfEmploees.Add(new Developer(3, "Stamat3", "Toshev3", 337, Department.Marketing));


            foreach (var emploee in listOfEmploees)
            {
                Console.WriteLine(emploee);
                Console.WriteLine();
            }


        }
    }
}
