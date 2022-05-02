using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersAsString = Console.ReadLine();
            int[] realNumbers = numbersAsString.Split(' ').Select(int.Parse).ToArray();
            Stack<int> numberInStack = new Stack<int>();
            int sum = 0;

            foreach (var number in realNumbers)
            {
                numberInStack.Push(number);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0].ToLower() == "end")
                {
                    break;
                }
                else if (command[0].ToLower() == "add")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        numberInStack.Push(Convert.ToInt32(command[i]));
                    }
                }
                else if (command[0].ToLower() == "remove")
                { 
                    if (Convert.ToInt32(command[1]) <= numberInStack.Count)
                    {
                        for (int i = 0; i < Convert.ToInt32(command[1]); i++)
                        {
                            numberInStack.Pop();
                        }
                    }
                }
            }

            while (numberInStack.Count > 0)
            {
                int number = numberInStack.Pop();
                sum += number;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
