using System;
using System.Linq;

namespace _1._6_JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            //  3
            //  1 2 3
            //  4 5 6
            //  7 8 9
            //  Add 0 0 5
            //  Subtract 1 1 2
            //  END

            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = new int[numbers.Length];

                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix[i][j] = numbers[j];
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                switch (command[0])
                {
                    case "Add":
                        if ((row < size && col < size) && (row >= 0 && col >= 0))
                        {
                            matrix[row][col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        if ((row < size && col < size) && (row >= 0 && col >= 0))
                        {
                            matrix[row][col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(String.Join(" ", matrix[i]));
            }
        }
    }
}
