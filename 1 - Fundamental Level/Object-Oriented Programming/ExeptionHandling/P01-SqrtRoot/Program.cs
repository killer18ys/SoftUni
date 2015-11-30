using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SqrtRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            try
            {
                Math.Sqrt(n);
            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
