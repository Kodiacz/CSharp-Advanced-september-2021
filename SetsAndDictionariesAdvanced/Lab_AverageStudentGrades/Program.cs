using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<double> { grade });
                }
                else
                {
                    grades[name].Add(grade);
                }
            }

            foreach (var name in grades)
            {
                double sum = 0;
                double average = 0;

                for (int i = 0; i < name.Value.Count; i++)
                {
                    sum += name.Value[i];
                }

                int countOfGrades = name.Value.Count;
                average = sum / countOfGrades;

                Console.WriteLine($"{name.Key} -> {string.Join(" ", name.Value.Select(x => string.Format("{0:F2}", x)))} (avg: {average:F2})");
            }
        }
    }
}
