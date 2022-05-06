using System;

namespace _1._7PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] pascalTriangle = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                pascalTriangle[i] = new int[i + 1];

                for (int k = 0; k < pascalTriangle[i].Length; k++)
                {
                    if (k == 0)
                    {
                        pascalTriangle[i][k] = 1;
                    }
                    else if (k == pascalTriangle[i].Length - 1)
                    {
                        pascalTriangle[i][k] = 1;
                    }
                    else
                    {
                        pascalTriangle[i][k] = pascalTriangle[i - 1][k] + pascalTriangle[i - 1][k - 1];
                    }
                }
            }

            foreach (int[] row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
