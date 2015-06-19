using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 3)
            {
                n *= 10;
            }
            else if (n >= 4 && n <= 6)
            {
                n *= 100;
            }
            else if (n >= 7 && n <= 9)
            {
                n *= 1000;
            }
            else
            {
                Console.WriteLine("Invalide Score");
                
                return;
            }

            Console.WriteLine(n);
        }
    }
}
