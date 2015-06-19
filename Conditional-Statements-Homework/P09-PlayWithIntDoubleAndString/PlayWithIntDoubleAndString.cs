using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            int choice = int.Parse(Console.ReadLine());
            int n;
            double d;
            string s;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter a int: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine(n + 1);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double: ");
                    d = double.Parse(Console.ReadLine());
                    Console.WriteLine(d + 1);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string: ");
                    s = Console.ReadLine();
                    Console.WriteLine(s + "*");
                    break;
                default:
                    Console.WriteLine("Not an option!");
                    break;
            }

        }
    }
}
