using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_20_11_2015.Models;

namespace Lab_20_11_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = Console.ReadLine();

            while (line != "End")
            {
                try
                {
                    LeagueManager.InputHandler(line);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }

                line = Console.ReadLine();
            }


        }
    }
}
