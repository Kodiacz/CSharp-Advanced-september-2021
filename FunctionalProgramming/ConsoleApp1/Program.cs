using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] twoNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Enumerable.Range(twoNumbers[0], (twoNumbers[1] - twoNumbers[0] + 1) ).ToArray();
            string command = Console.ReadLine();
            Predicate<int> even = number => number % 2 == 0;
            Predicate<int> odd = number => number % 2 != 0;

            if (command == "even")
            {
                foreach (int number in numbers)
                {
                    if (even(number))
                    {
                        Console.Write($"{number} ");
                    }
                }
            }
            else
            {
                foreach (int number in numbers)
                {
                    if (odd(number))
                    {
                        Console.Write($"{number} ");
                    }
                }
            }
        }
    }
}
