using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_CustomLINQExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var filteredNums = nums.WhereNot(n => n%2 == 0);

            Console.WriteLine(string.Join(", ", filteredNums));




            List<Student> students = new List<Student>()
            {
                new Student("Petko", 13),
                new Student("Pesho", 19),
                new Student("Stamat", 17),
                new Student("Vasko", 14)
            };

            Console.WriteLine(students.Max(student => student.Age));

        }
    }
}
