using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string command = line.Split(' ')[0];
                if (command == "exchange")
                {
                    int index = int.Parse(line.Split(' ')[1]);
                    if (index >= numbers.Length || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers = Exchange(numbers, index);
                    }
                }
                else if (command == "max")
                {
                    string evenOrOdd = line.Split(' ')[1];

                    int maxIndex = FindMax(numbers, evenOrOdd);

                    if (maxIndex != -1)
                    {
                        Console.WriteLine(maxIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }

                }
                else if (command == "min")
                {
                    string evenOrOdd = line.Split(' ')[1];

                    int minIndex = FindMin(numbers, evenOrOdd);

                    if (minIndex != -1)
                    {
                        Console.WriteLine(minIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (command == "first")
                {
                    int count = int.Parse(line.Split(' ')[1]);
                    string evenOrOdd = line.Split(' ')[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int[] firstNNumbers = FindFirstNOddOrEven(numbers, count, evenOrOdd);

                        if (firstNNumbers.Length != 0)
                        {
                            Console.WriteLine("[{0}]", string.Join(", ", firstNNumbers));
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }

                    }

                }
                else if(command == "last")
                {
                    int count = int.Parse(line.Split(' ')[1]);
                    string evenOrOdd = line.Split(' ')[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int[] lastNNumbers = FindLastNOddOrEven(numbers, count, evenOrOdd);

                        if (lastNNumbers.Length != 0)
                        {
                            Console.WriteLine("[{0}]", string.Join(", ", lastNNumbers));
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }

                    }
                }



                line = Console.ReadLine();
            }


            Console.WriteLine("[{0}]",string.Join(", ", numbers));
        }
        static int[] FindLastNOddOrEven(int[] numbers, int count, string evenOrOdd)
        {
            int[] result;

            try
            {
                if (evenOrOdd == "even")
                {
                    result = numbers.Where(number => number % 2 == 0).Reverse().Take(count).Reverse().ToArray();
                }
                else
                {
                    result = numbers.Where(number => number % 2 != 0).Reverse().Take(count).Reverse().ToArray();
                }
            }
            catch (AggregateException)
            {

                return new int[] { };
            }

            return result;

        }


        static int[] FindFirstNOddOrEven(int[] numbers, int count, string evenOrOdd)
        {
            int[] result;

            try
            {
                if (evenOrOdd == "even")
                {
                    result = numbers.Where(number => number % 2 == 0).Take(count).ToArray();
                }
                else
                {
                    result = numbers.Where(number => number % 2 != 0).Take(count).ToArray();
                }
            }
            catch (AggregateException)
            {

               return  new int[] {};
            }

            return result;

        }

        static int FindMin(int[] numbers, string evenOrOdd)
        {
            int minValue;

            try
            {
                if (evenOrOdd == "even")
                {
                    minValue = numbers.Where(number => number % 2 == 0).Min();
                }
                else
                {
                    minValue = numbers.Where(number => number % 2 != 0).Min();
                }
            }
            catch (Exception)
            {

                return -1;
            }

            int minIndex = numbers.ToList().LastIndexOf((minValue));

            return minIndex;
        }

        static int FindMax(int[] numbers, string evenOrOdd)
        {
            int maxValue;

            try
            {
                if (evenOrOdd == "even")
                {
                    maxValue = numbers.Where(number => number % 2 == 0).Max();
                }
                else
                {
                    maxValue = numbers.Where(number => number % 2 != 0).Max();
                }
            }
            catch (Exception)
            {

                return -1;
            }

            int maxIndex = numbers.ToList().LastIndexOf((maxValue));

            return maxIndex;
        }


        static int[] Exchange(int[] numbers, int index)
        {
            int[] firstPart = numbers.Take(index + 1).ToArray();
            int[] secondPart = numbers.Skip(index + 1).Take(numbers.Length - index - 1).ToArray();

            int[] exchangeArray = new int[firstPart.Length + secondPart.Length];
            secondPart.CopyTo(exchangeArray, 0);
            firstPart.CopyTo(exchangeArray, secondPart.Length);

            return exchangeArray;
        }


    }
}
