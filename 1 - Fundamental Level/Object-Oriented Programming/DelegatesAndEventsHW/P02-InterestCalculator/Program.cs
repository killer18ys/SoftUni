using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, int, decimal> compound = GetCompoundInterest;
            Func<decimal, decimal, int, decimal> simple = GetSimpleInterest;

            var iCalc1 = new InterestCalculator(500m, 5.6m, 10, compound);
            var iCalc2 = new InterestCalculator(2500m, 7.2m, 15, simple);


            Console.WriteLine(iCalc1);
            Console.WriteLine();
            Console.WriteLine(iCalc2);


        }


        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum*(1 + interest / 100 * years);
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + interest / 100 / 12), years * 12);  
        }
    }
}
