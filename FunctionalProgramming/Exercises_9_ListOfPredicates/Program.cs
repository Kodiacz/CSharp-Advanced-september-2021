using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises_9_ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] divNumbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
            int[] numbers = Enumerable.Range(1, n).ToArray();
            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var number in divNumbers)
            {
                predicates.Add(x => x % number == 0);
            }

            foreach (var number in numbers)
            {
                bool isDivisible = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
