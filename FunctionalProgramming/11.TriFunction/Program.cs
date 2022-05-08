using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guestList = Console.ReadLine().Split().ToList();

            Func<string, int, bool> findSum = (name, number) => name.Sum(x => x) >= number;
            //{
            //    int sum = 0;

            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        sum += name[i];
            //    }

            //    return sum >= number;
            //};

            Func<Func<string, int, bool>, List<string>, string> print = (func, list) => list.FirstOrDefault(x => func(x, n));
            //{
            //    string result = string.Empty;

            //    foreach (var name in list)
            //    {
            //        if (func(name, n))
            //        {
            //            result = name;
            //            break;
            //        }
            //    }

            //    return result;
            //};

            Console.WriteLine(print(findSum, guestList));
        }
    }
}
