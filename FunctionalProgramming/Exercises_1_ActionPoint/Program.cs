using System;

namespace Exercises_1_ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string> print = text => Console.WriteLine(text);

            foreach (string word in input)
            {
                print(word);
            }
        }
    }
}
