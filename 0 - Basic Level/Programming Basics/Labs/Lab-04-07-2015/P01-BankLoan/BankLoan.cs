using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BankLoan
{
    class BankLoan
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double bankIntRate = double.Parse(Console.ReadLine());
            double friendRate = double.Parse(Console.ReadLine());

            double frienMoney = 0;
            double bankMoney = price;

            
                bankMoney = (price * Math.Pow((1 + bankIntRate), term));
                frienMoney = price * (1 + friendRate);

            if (bankMoney < frienMoney)
            {
                Console.WriteLine("{0:F2} Bank", bankMoney);
            }
            else if (bankMoney > frienMoney)
            {
                Console.WriteLine("{0:F2} Friend", frienMoney);
            }
            else
            {
                Console.WriteLine("{0:F2} Friend", frienMoney);
            }
        }
    }
}
