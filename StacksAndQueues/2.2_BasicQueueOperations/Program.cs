using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._2_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);

            Queue<int> elements = new Queue<int>();
            int[] pushedElement = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                elements.Enqueue(pushedElement[i]);
            }

            for (int i = 0; i < s; i++)
            {
                elements.Dequeue();
            }

            if (elements.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (elements.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int smallestNumber = int.MaxValue;

                while (elements.Count > 0)
                {
                    if (smallestNumber > elements.Peek())
                    {
                        smallestNumber = elements.Dequeue();
                    }
                    else
                    {
                        elements.Dequeue();
                    }
                }

                Console.WriteLine(smallestNumber);
            }
        }
    }
}
