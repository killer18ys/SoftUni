using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_CensorEmail
{
    class CensorEmail
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(CensorEmailParser(input));
           
        }


        static string CensorEmailParser(string email)
        {
           int usernameLength =  email.IndexOf('@');
           string placeHolder = new string('*', usernameLength);
           string username = string.Join("", email.Take(usernameLength).ToArray());

           return email.Replace(username, placeHolder);
        }

    }
}
