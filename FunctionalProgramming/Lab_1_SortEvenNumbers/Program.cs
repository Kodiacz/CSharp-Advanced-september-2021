using System;
using System.Linq;

namespace Lab_1_SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
            Array.Sort(evenNumbers);
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
