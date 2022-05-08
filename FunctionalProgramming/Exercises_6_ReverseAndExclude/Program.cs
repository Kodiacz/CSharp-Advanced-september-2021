using System;
using System.Linq;

namespace Exercises_6_ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            Array.Reverse(numbers);
            numbers = numbers.Where(n => n % number != 0).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
