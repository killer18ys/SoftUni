using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Tosho1", "Pashev1", "121215023"));
            students.Add(new Student("Tosho2", "Pashev2", "721215023"));
            students.Add(new Student("Tosho3", "Pashev3", "321215023"));
            students.Add(new Student("Tosho4", "Pashev4", "521215023"));
            students.Add(new Student("Tosho5", "Pashev5", "121215123"));
            students.Add(new Student("Tosho6", "Pashev6", "421215023"));
            students.Add(new Student("Tosho7", "Pashev7", "121215023"));
            students.Add(new Student("Tosho8", "Pashev8", "921215023"));
            students.Add(new Student("Tosho9", "Pashev9", "621215023"));
            students.Add(new Student("Tosho10", "Pashev10", "021215023"));

            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Stamat1", "Trendafilov1", 300, 12));
            workers.Add(new Worker("Stamat2", "Trendafilov2", 400, 12));
            workers.Add(new Worker("Stamat3", "Trendafilov3", 500, 12));
            workers.Add(new Worker("Stamat4", "Trendafilov4", 600, 12));
            workers.Add(new Worker("Stamat5", "Trendafilov5", 777, 3));
            workers.Add(new Worker("Stamat6", "Trendafilov6", 7777, 7));
            workers.Add(new Worker("Stamat7", "Trendafilov7", 3777, 8));
            workers.Add(new Worker("Stamat8", "Trendafilov8", 3000, 12));
            workers.Add(new Worker("Stamat9", "Trendafilov9", 2000, 12));
            workers.Add(new Worker("Stamat10", "Trendafilov10", 1500, 12));


            foreach (Student student in students.OrderBy(s => s.FacultyNumber))
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            foreach (Worker worker in workers.OrderByDescending(w => w.MoneyPerHour()))
            {
                Console.WriteLine(worker);   
            }

        }
    }
}
