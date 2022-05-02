using System;
using System.Collections.Generic;

namespace _3._1ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> orderedOutput = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                orderedOutput.Push(input[i]);
            }

            Console.WriteLine(string.Join(" ", orderedOutput));
        }
    }
}
