using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P02_LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Killer18ys\Desktop\testFile.txt";
            string newFilePath = @"C:\Users\Killer18ys\Desktop\newTestFile.txt";
            int line = 1;
            string currLine;

            StreamReader fileReadStream = new StreamReader(filePath);
            StreamWriter newFileWriteStream = new StreamWriter(newFilePath);

            using (fileReadStream)
            {
                using (newFileWriteStream)
                {
                    while (fileReadStream.Peek() >= 0)
                    {
                        currLine = fileReadStream.ReadLine();
                        newFileWriteStream.WriteLine(line + ". " + currLine);

                        line++;
                    }
                }
            }
            

        }
    }
}
