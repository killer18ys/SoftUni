using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsolePrintFormat
{
    class ConsolePrintFormat
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            Console.Write("|{0,-10:X}", a);
            Console.Write("|{0}|", Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("{0,10:F2}|", b);
            Console.WriteLine("{0,-10:F3}|", c);



        }
    }
}
