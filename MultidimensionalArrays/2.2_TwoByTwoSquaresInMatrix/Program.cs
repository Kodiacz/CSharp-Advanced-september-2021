using System;
using System.Linq;

namespace _2._2_TwoByTwoSquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];
            int countOfEqualCells = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] symbols = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = symbols[k];
                }
            }

            for (int i = 0; i < size[0] - 1; i++)
            {
                for (int k = 0; k < size[1] - 1; k++)
                {
                    if (matrix[i, k] == matrix[i, k + 1] && matrix[i, k] == matrix[i + 1, k] && matrix[i, k] == matrix[i + 1, k + 1])
                    {
                        countOfEqualCells++;
                    }
                }
            }

            Console.WriteLine(countOfEqualCells);
        }
    }
}
