using System;
using System.Linq;

namespace _2._3_MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            int[,] subMatrix = new int[3, 3];
            long maxSum = long.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = numbers[k];
                }
            }

            for (int i = 0; i < size[0] - 2; i++)
            {
                for (int k = 0; k < size[1] - 2; k++)
                {
                    int sum = matrix[i, k] + matrix[i, k + 1] + matrix[i, k + 2] +
                              matrix[i + 1, k] + matrix[i + 1, k + 1] + matrix[i + 1, k + 2] +
                              matrix[i + 2, k] + matrix[i + 2, k + 1] + matrix[i + 2, k + 2];

                    int[] numbers = new int[]
                    {
                        matrix[i, k], matrix[i, k + 1], matrix[i, k + 2],
                        matrix[i + 1, k], matrix[i + 1, k + 1], matrix[i + 1, k + 2],
                        matrix[i + 2, k], matrix[i + 2, k + 1], matrix[i + 2, k + 2]
                    };

                    int index = 0;

                    if (sum > maxSum)
                    {
                        maxSum = sum;

                        for (int row = 0; row < 3; row++)
                        {
                            for (int col = 0; col < 3; col++)
                            {
                                subMatrix[row, col] = numbers[index];
                                index++;
                            }
                        }
                    }

                    sum = 0;
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (k == 2)
                    {
                        Console.WriteLine(subMatrix[i, k]);
                        break;
                    }

                    Console.Write(subMatrix[i, k] + " ");
                }
            }
        }
    }
}

