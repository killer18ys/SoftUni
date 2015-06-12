using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] digits = new int[4];
            int count = 0;
            int length = digits.Length;
            int sumOfDigits = 0;
            int reversedNum = 0;
            int lastDigitInFront;
            int secondAndThirdDigitExechenged;

            while (n != 0)
            {
                digits[count] = n % 10;
                n /= 10;
                count++;
            }

            foreach (int digit in digits)
            {
                sumOfDigits += digit;
            }


            for (int i = 1; i <= length; i++)
            {
                reversedNum += digits[i-1] * (int)Math.Pow(10, length - i);
            }

            lastDigitInFront = digits[0] * 1000 + digits[3] * 100 + digits[2] * 10 + digits[1];

            secondAndThirdDigitExechenged = digits[3] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[0]; 

            Console.WriteLine(sumOfDigits);
            Console.WriteLine(reversedNum);
            Console.WriteLine(lastDigitInFront);
            Console.WriteLine(secondAndThirdDigitExechenged);

        }
    }
}
