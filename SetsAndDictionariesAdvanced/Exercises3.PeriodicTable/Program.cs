using System;
using System.Collections.Generic;

namespace Exercises3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int k = 0; k < input.Length; k++)
                {
                    elements.Add(input[k]);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
