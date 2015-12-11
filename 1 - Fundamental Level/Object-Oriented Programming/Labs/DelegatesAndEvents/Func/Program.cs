using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> coleInts = new List<int>{1, 2, 3, 4, 5, 6, 11, 3};

           Console.WriteLine(string.Join(", ", coleInts.TakeWhile(x => x < 10)));
        }
    }
}
