using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_PetarGame
{
    class PetarGame
    {
        static void Main(string[] args)
        {
            ulong startNum = ulong.Parse(Console.ReadLine());
            ulong endNum = ulong.Parse(Console.ReadLine());
            string replaceStr = Console.ReadLine();

            decimal sum = 0;

            for (ulong i = startNum; i < endNum; i++)
            {
                if ((i % 5) == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += (i % 5);
                }
            }

            string strNum = sum.ToString();
            string firstDigit = strNum[0].ToString();
            string lastDigit = strNum[strNum.Length - 1].ToString();

            if ((sum % 2) == 0)
            {
                strNum = strNum.Replace(firstDigit, replaceStr);
            }
            else
            {
                strNum = strNum.Replace(lastDigit, replaceStr);
            }

            Console.WriteLine(strNum);
        }
    }
}
