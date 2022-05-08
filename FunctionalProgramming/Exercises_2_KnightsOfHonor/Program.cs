using System;

namespace Exercises_2_KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string> print = name => Console.WriteLine($"Sir {name}");

            foreach (string name in names)
            {
                print(name);
            }
        }
    }
}
