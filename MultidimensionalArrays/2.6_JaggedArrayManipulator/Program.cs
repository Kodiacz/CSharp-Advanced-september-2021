using System;
using System.Linq;

namespace _2._6_JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            // loop for populating the matrix
            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                matrix[i] = new int[numbers.Length];

                for (int k = 0; k < numbers.Length; k++)
                {
                    if (int.TryParse(numbers[k], out matrix[i][k]))
                    {
                        matrix[i][k] = Convert.ToInt32(numbers[k]);
                    }
                }
            }

            // loop for analyzing the matrix
            for (int i = 0; i < n - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    // loop for first and second row
                    for (int k = 0; k < matrix[i].Length; k++)
                    {
                        matrix[i][k] *= 2;
                        matrix[i + 1][k] *= 2;
                    }
                }
                else
                {
                    // loop for first row
                    for (int k = 0; k < matrix[i].Length; k++)
                    {
                        matrix[i][k] /= 2;
                    }

                    // loop for second row
                    for (int s = 0; s < matrix[i + 1].Length; s++)
                    {
                        matrix[i + 1][s] /= 2;
                    }
                }
            }

            // manipulating the matrix

            string[] input = Console.ReadLine().Split();
            string command = input[0];

            while (command != "End")
            {
                switch (command)
                {
                    case "Add":
                        if (int.TryParse(input[1], out int row) && int.TryParse(input[2], out int col) && int.TryParse(input[3], out int value))
                        {
                            row = int.Parse(input[1]);
                            col = int.Parse(input[2]);
                            value = int.Parse(input[3]);

                            if ((row >= 0 && row < n) && (col >= 0 && col < matrix[row].Length))
                            {
                                matrix[row][col] += value;
                            }
                        }
                        break;
                    case "Subtract":
                        if (int.TryParse(input[1], out row) && int.TryParse(input[2], out col) && int.TryParse(input[3], out value))
                        {
                            row = int.Parse(input[1]);
                            col = int.Parse(input[2]);
                            value = int.Parse(input[3]);

                            if ((row >= 0 && row < n) && (col >= 0 && col < matrix[row].Length))
                            {
                                matrix[row][col] -= value;
                            }
                        }
                        break;
                }

                input = Console.ReadLine().Split();
                command = input[0];
            }

            // pringing the matrix

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
