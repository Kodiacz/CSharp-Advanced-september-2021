using System;
using System.Collections.Generic;

namespace Exercises_2.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int firstLenght = int.Parse(input[0]);
            int secondLenght = int.Parse(input[1]);

            HashSet<string> firstNumbers = new HashSet<string>();
            HashSet<string> secondNumbers = new HashSet<string>();

            for (int i = 0; i < firstLenght; i++)
            {
                string number = Console.ReadLine();

                firstNumbers.Add(number);
            }

            for (int i = 0; i < secondLenght; i++)
            {
                string number = Console.ReadLine();

                secondNumbers.Add(number);
            }

            foreach (var item in firstNumbers)
            {
                if (secondNumbers.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
