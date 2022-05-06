using System;
using System.Linq;

namespace _2._4_MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = input[k];
                }
            }

            string[] command = Console.ReadLine().Split();
            int firstRowIndex = 0;
            int firstColIndex = 0;
            int secondRowIndex = 0;
            int secondColIndex = 0;

            while (command[0] != "END")
            {
                if (command.Length == 5)
                {
                    // check if input for indexes is numeric
                    if (int.TryParse(command[1], out firstRowIndex) && int.TryParse(command[1], out firstColIndex) && int.TryParse(command[1], out secondRowIndex) && int.TryParse(command[1], out secondColIndex))
                    {
                        firstRowIndex = int.Parse(command[1]);
                        firstColIndex = int.Parse(command[2]);
                        secondRowIndex = int.Parse(command[3]);
                        secondColIndex = int.Parse(command[4]);

                        if ((firstRowIndex < matrix.GetLength(0) && firstRowIndex >= 0) && (firstColIndex < matrix.GetLength(1) && firstColIndex >= 0) && (secondColIndex < matrix.GetLength(1) && secondColIndex >= 0) && (secondRowIndex < matrix.GetLength(0) && secondRowIndex >= 0))
                        {
                            string firstValue = matrix[firstRowIndex, firstColIndex];
                            string secondValue = matrix[secondRowIndex, secondColIndex];
                            matrix[firstRowIndex, firstColIndex] = secondValue;
                            matrix[secondRowIndex, secondColIndex] = firstValue;

                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int k = 0; k < matrix.GetLength(1); k++)
                                {
                                    if (k == matrix.GetLength(1) - 1)
                                    {
                                        Console.WriteLine(matrix[i, k]);
                                        break;
                                    }

                                    Console.Write(matrix[i, k] + " ");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


                command = Console.ReadLine().Split();
            }
        }
    }
}
