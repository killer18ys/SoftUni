using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_ShmoogleCounter
{
    class ShmoogleCounter
    {
        static void Main(string[] args)
        {
            string pattern = @"(\bint|double\b)\s+(\w+)";
            Regex rgx = new Regex(pattern);

            StringBuilder inputData = new StringBuilder();

            string line = Console.ReadLine();

            while (line != "//END_OF_CODE")
            {
                inputData.Append(line);
                inputData.Append(Environment.NewLine);

                line = Console.ReadLine();
            }

            MatchCollection matches = rgx.Matches(inputData.ToString());
            List<string> intVarSet = new List<string>();
            List<string> doubleVarSet = new List<string>();

            foreach (Match match in matches)
            {
                string type = match.Groups[1].Value;
                string varName = match.Groups[2].Value;

                if (type.Equals("int"))
	            {
                    intVarSet.Add(varName);
	            }
                else if (type.Equals("double"))
	            {
		            doubleVarSet.Add(varName);
	            }
            }
            if (doubleVarSet.Count != 0)
            {
                Console.WriteLine("Doubles: {0}", string.Join(", ", doubleVarSet.OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine("Doubles: None");
            }

            if (intVarSet.Count != 0)
            {
                Console.WriteLine("Ints: {0}", string.Join(", ", intVarSet.OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine("Ints: None");
            }
        }
    }
}
