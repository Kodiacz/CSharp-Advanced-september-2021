using System;
using System.Linq;

namespace _1._3PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int diagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int k = 0; k < size; k++)
                {
                    matrix[i, k] = numbers[k];
                }

                diagonalSum += matrix[i, i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
