using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digit;
            int count = 0;
            bool isDigit7 = false;

            while (n != 0)
            {
                digit = n % 10;

                n /= 10;
                count++;

                if (count == 3 && digit == 7)
                {
                    isDigit7 = true;
                }
            }


            Console.WriteLine(isDigit7);

        }
    }
}
