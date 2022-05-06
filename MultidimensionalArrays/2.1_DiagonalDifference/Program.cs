using System;
using System.Linq;

namespace _2._1_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int sumOfRightDiagonal = 0;
            int sumOfLeftDiagonal = 0;

            for (int i = 0; i < size; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                for (int k = 0; k < size; k++)
                {
                    matrix[i, k] = numbers[k];
                }

                sumOfRightDiagonal += matrix[i, i];
                sumOfLeftDiagonal += matrix[i, size - 1 - i];
            }

            int aboluteSum = Math.Abs(sumOfLeftDiagonal - sumOfRightDiagonal);
            Console.WriteLine(aboluteSum);
        }
    }
}
