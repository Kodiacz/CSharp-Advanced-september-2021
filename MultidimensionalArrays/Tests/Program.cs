using System;
using System.Linq;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); 
            int sumOfCollums = 0;
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] number = Console.ReadLine().Split(", ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(number[col]);
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfCollums += matrix[row, col];
                }

                Console.WriteLine(sumOfCollums);
                sumOfCollums = 0;
            }
        }
    }
}
