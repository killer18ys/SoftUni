using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            String s1 = "Hello";
            String s2 = "World";

            Object obj = s1 + " " +  s2;

            String objInStr = obj.ToString();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(obj);
            Console.WriteLine(objInStr);
        }
    }
}
