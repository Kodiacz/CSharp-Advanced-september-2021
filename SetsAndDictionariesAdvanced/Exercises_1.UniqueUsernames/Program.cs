using System;
using System.Collections.Generic;

namespace Exercises_1.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
