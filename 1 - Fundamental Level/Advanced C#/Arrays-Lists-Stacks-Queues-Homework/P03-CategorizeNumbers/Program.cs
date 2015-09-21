using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_CategorizeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            float[] numbers = input.Split(' ').Select(float.Parse).ToArray();

            List<float> floatNumbers = new List<float>();
            List<int> intNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 1) == 0)
	            {
		            intNumbers.Add((int)numbers[i]);
                    
	            }
                else{
                    floatNumbers.Add(numbers[i]);
                }
            }


            Console.WriteLine("[{0}] -> Min: {1}, Max:{2}, Average:{3}, Sum:{4} ", string.Join(", ", floatNumbers), floatNumbers.Min(), floatNumbers.Max(), floatNumbers.Average(), floatNumbers.Sum());
            Console.WriteLine("[{0}] -> Min: {1}, Max:{2}, Average:{3}, Sum:{4} ", string.Join(", ", intNumbers), intNumbers.Min(), intNumbers.Max(), intNumbers.Average(), intNumbers.Sum());
        }
    }
}
