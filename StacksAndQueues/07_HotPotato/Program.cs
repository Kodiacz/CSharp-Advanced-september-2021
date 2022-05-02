using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> input = Console.ReadLine().Split().ToList();
            Queue<string> names = new Queue<string>();
            int countOfInput = input.Count;
            int potato = int.Parse(Console.ReadLine());
            int index = -1;

            while (names.Count < countOfInput)
            {
                for (int i = 0; i < potato; i++)
                {
                    if (index >= input.Count - 1)
                    {
                        index = -1;
                    }

                    index++;
                }

                names.Enqueue(input[index]);
                input.RemoveAt(index);

                if (index <= input.Count - 1)
                {
                    index--;
                }
            }

            while (names.Count > 1)
            {
                Console.WriteLine("Removed " + names.Dequeue());
            }

            Console.WriteLine($"Last is {names.Peek()}");
        }
    }
}
