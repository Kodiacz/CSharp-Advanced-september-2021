using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._3MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNumber = int.MinValue;
            Stack<int> elements = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (numbers[0] == 1)
                {
                    elements.Push(numbers[1]);

                    if (numbers[1] > biggestNumber)
                    {
                        biggestNumber = numbers[1];
                    }
                }
                else if (numbers[0] == 2)
                {
                    if (biggestNumber == elements.Peek())
                    {
                        biggestNumber = int.MinValue;
                    }

                    elements.Pop();
                }
                else if (numbers[0] == 3)
                {
                    //if (elements.Count > 0)
                    //{
                    //    Console.WriteLine(biggestNumber);
                    //}

                    Console.WriteLine(elements.Max());
                }
            }
        }
    }
}

