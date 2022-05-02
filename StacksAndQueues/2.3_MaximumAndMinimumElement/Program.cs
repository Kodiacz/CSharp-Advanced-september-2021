using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._3_MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> elements = new Stack<int>();
            int numberOfQueries = int.Parse(Console.ReadLine());
            int maxElement = int.MinValue;
            int minElement = int.MaxValue;
            
            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int querie = input[0];
                
                if (querie == 1)
                {
                    int element = input[1];
                    elements.Push(element);

                    if (element > maxElement)
                    {
                        maxElement = element;
                    }
                    
                    if (element < minElement)
                    {
                        minElement = element;
                    }
                }
                else if (querie == 2)
                {
                    if (elements.Peek() == maxElement)
                    {
                        maxElement = int.MinValue;
                    }

                    if (elements.Peek() == minElement)
                    {
                        minElement = int.MaxValue;
                    }

                    elements.Pop();
                }
                else if (querie == 3)
                {
                    if (elements.Count > 0)
                    {
                        Console.WriteLine(maxElement);
                    }
                }
                else if (querie == 4)
                {
                    if (elements.Count > 0)
                    {
                        Console.WriteLine(minElement);
                    }
                }
            }

            while (elements.Count > 0)
            {
                if (elements.Count == 1)
                {
                    Console.Write($"{elements.Pop()}");
                    continue;
                }

                Console.Write($"{elements.Pop()}, ");
            }
        }
    }
}
