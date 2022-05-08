using System;
using System.Linq;

namespace Exercises_05_AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Func<int[], int[]> add = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]++;
                }

                return numbers;
            };

            Func<int[], int[]> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }

                return numbers;
            };

            Func<int[], int[]> substract = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]--;
                }

                return numbers;
            };

            Action<int[]> printingArray = numbers =>
            {
                Console.WriteLine(string.Join(" ", numbers));
            };

            while (true)
            {
                switch (command)
                {
                    case "add":
                        add(numbers);
                        break;
                    case "multiply":
                        multiply(numbers);
                        break;
                    case "subtract":
                        substract(numbers);
                        break;
                    case "print":
                        printingArray(numbers);
                        break;
                }

                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
            }

        }
    }
}
