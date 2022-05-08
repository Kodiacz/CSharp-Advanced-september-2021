using System;
using System.Linq;

namespace Lab_2_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4, 2, 1, 3, 5, 7, 1, 4, 2, 12 = 10, 41
            // 2, 4, 6 = 3, 12

            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int count = numbers.Length;
            int sum = numbers.Sum();

            Action<string> print = x => Console.WriteLine(x);

            print(count.ToString());
            print(sum.ToString());
        }
    }
}
