using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_NineDigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());

            int abc = 0;
            int def = 0;
            int ghi = 0;

            int digitSum = 0;
            int temp;
            int digit;
            bool pass = true;
            int count = 0;

            for (int i = 111; i <= 777; i++)
            {     
                        def = i;
                        abc = def - diff;
                        ghi = def + diff;

                        if (abc < 100 || ghi > 777)
                        {
                            continue;
                        }


                        temp = abc;
                        while (temp != 0)
                        {
                            digit = temp % 10;
                            if (digit < 1 || digit > 7)
                            {
                                pass = false;
                            }
                            digitSum += digit;
                            temp /= 10;
                        }

                        temp = ghi;
                        while (temp != 0)
                        {
                            digit = temp % 10;
                            if (digit < 1 || digit > 7)
                            {
                                pass = false;
                            }
                            digitSum += digit;
                            temp /= 10;
                        }

                        temp = def;
                        while (temp != 0)
                        {
                            digit = temp % 10;
                            if (digit < 1 || digit > 7)
                            {
                                pass = false;
                            }
                            digitSum += digit;
                            temp /= 10;
                        }

                        if (sum == digitSum && pass)
                        {
                            Console.Write(abc);
                            Console.Write(def);
                            Console.WriteLine(ghi);
                            count += 1;
                        }
                        digitSum = 0;
                        pass = true;
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
