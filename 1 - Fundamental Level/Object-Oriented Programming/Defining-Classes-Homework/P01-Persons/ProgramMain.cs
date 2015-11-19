using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Persons
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
                Person Tarzan = new Person("Tarzan", 23);
                Person Pesho = new Person("Pesho", 19, "putkorazbivach_2000@abv.bg");
                Person Zoro = new Person("Zoro", 37, "mnogo_gotin_abv.bg");


                Console.WriteLine(Tarzan);
                Console.WriteLine(Pesho);
                Console.WriteLine(Zoro);
                


        }
    }
}
