using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Queue<int> test1 = new Queue<int>(numbers);
            Stack<int> test2 = new Stack<int>(numbers);

            Console.WriteLine(string.Join(", ", test1));
            Console.WriteLine(string.Join(", ", test2));
            Console.WriteLine(test1.Count);
            Console.WriteLine(test2.Count);

            Console.WriteLine();

            foreach (var item in test1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in test1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(test1.Count);
            Console.WriteLine(test2.Count);
        }
    }
}
