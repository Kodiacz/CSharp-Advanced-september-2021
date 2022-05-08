using System;
using System.Linq;

namespace Exercises_3_CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minFunction = numbers =>
            {
                int minNumber = int.MaxValue;

                foreach (int number in numbers)
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }

                return minNumber;
            };

            int minNumber = minFunction(numbers);
            Console.WriteLine(minNumber);
        }
    }
}
