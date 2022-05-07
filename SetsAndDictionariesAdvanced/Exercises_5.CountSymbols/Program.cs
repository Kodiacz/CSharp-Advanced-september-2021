using System;
using System.Collections.Generic;

namespace Exercises_5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbolsCount.ContainsKey(input[i]))
                {
                    symbolsCount.Add(input[i], 0);
                }

                symbolsCount[input[i]]++;
            }

            foreach (var symbol in symbolsCount)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
