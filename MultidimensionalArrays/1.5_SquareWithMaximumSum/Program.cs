using System;
using System.Linq;

namespace _1._5_SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimentions[0], dimentions[1]];
            int[,] square = new int[2, 2];
            long maxSum = long.MinValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;

                        int squareNumbersIndex = 0;
                        int[] squareNumbers = new int[]
                            {
                                matrix[row, col],
                                matrix[row, col + 1],
                                matrix[row + 1, col],
                                matrix[row + 1, col + 1]
                            };

                        for (int i = 0; i < square.GetLength(0); i++)
                        {
                            for (int j = 0; j < square.GetLength(1); j++)
                            {
                                square[i, j] = squareNumbers[squareNumbersIndex];
                                squareNumbersIndex++;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < square.GetLength(0); i++)
            {
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    Console.Write(square[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
