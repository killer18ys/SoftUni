using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P01_OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Killer18ys\Desktop\testFile.txt";
            int count = 0;

            StreamReader fileReadStream = new StreamReader(filePath);

            using (fileReadStream)
            {
                while (fileReadStream.Peek() >= 0)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(fileReadStream.ReadLine());
                    }
                    else
                    {
                        fileReadStream.ReadLine();
                    }

                    count++;
                }
    
            }
            
        }
    }
}
