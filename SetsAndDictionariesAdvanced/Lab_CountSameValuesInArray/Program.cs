using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> countValues = new Dictionary<double, int>();
            double[] values = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < values.Length; i++)
            {
                if (!countValues.ContainsKey(values[i]))
                {
                    countValues.Add(values[i], 1);
                }
                else
                {
                    countValues[values[i]]++;
                }
            }

            foreach (var value in countValues)
            {
                if (value.Value == 1)
                {
                    Console.WriteLine($"{value.Key} - {value.Value} time");
                }
                else if (value.Value > 1)
                {
                    Console.WriteLine($"{value.Key} - {value.Value} times");
                }
            }
        }
    }
}
