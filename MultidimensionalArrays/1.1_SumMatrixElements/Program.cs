using System;
using System.Linq;

namespace _1._1_SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimentions[0], dimentions[1]];
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(dimentions[0]);
            Console.WriteLine(dimentions[1]);
            Console.WriteLine(sum);
        }
    }
}
