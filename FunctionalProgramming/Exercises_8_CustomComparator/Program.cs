using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises_8_CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> CustomComparator = numbers =>
            {
                List<int> evenNumbers = new List<int>();
                List<int> oddNUmbers = new List<int>();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenNumbers.Add(numbers[i]);
                    }
                    else
                    {
                        oddNUmbers.Add(numbers[i]);
                    }
                }

                evenNumbers.Sort();
                oddNUmbers.Sort();
                int numbersIndex = 0;

                for (int i = 0; i < evenNumbers.Count; i++)
                {
                    numbers[numbersIndex] = evenNumbers[i];
                    numbersIndex++;
                }

                for (int i = 0; i < oddNUmbers.Count; i++)
                {
                    numbers[numbersIndex] = oddNUmbers[i];
                    numbersIndex++;
                }

                return numbers;
            };

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            CustomComparator(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
