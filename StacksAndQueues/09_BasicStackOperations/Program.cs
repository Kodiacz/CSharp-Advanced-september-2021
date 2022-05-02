using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);

            Stack<int> elements = new Stack<int>();
            int[] pushedElement = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                elements.Push(pushedElement[i]);
            }
            
            for (int i = 0; i < s; i++)
            {
                elements.Pop();
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
                Console.WriteLine(elements.Peek());
            }
        }
    }
}
