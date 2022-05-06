using System;
using System.Linq;

namespace _2._5_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            int snakeIndex = 0;
            char[,] matrix = new char[size[0], size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                // forward loop
                if (i % 2 == 0)
                {
                    for (int f = 0; f < size[1]; f++)
                    {
                        if (snakeIndex > snake.Length - 1)
                        {
                            snakeIndex = 0;
                        }

                        matrix[i, f] = snake[snakeIndex];
                        snakeIndex++;
                    }
                }
                // backwards
                else
                {
                    for (int b = size[1] - 1; b >= 0; b--)
                    {
                        if (snakeIndex > snake.Length - 1)
                        {
                            snakeIndex = 0;
                        }

                        matrix[i, b] = snake[snakeIndex];
                        snakeIndex++;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k]);
                }

                Console.WriteLine();
            }
        }
    }
}

