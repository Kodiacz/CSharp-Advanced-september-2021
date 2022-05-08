using System;
using System.Linq;

namespace Exercises_7_PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> filteringNames = (name, length) => name.Length <= length;
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            //names = names.Where(name => name.Length <= n).ToArray(); 
            names = names.Where(name => filteringNames(name, n)).ToArray(); // LEARN THE SYNTAX
            Console.WriteLine(string.Join("\n", names));
        }
    }
}
