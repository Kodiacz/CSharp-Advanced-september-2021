using System;
using System.Linq;

namespace _1._4_SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];
            string output = "";

            for (int i = 0; i < size; i++)
            {
                string numbers = Console.ReadLine();

                for (int k = 0; k < size; k++)
                {
                    matrix[i, k] = Convert.ToString(numbers[k]);
                }
            }

            string symbol = Console.ReadLine();

            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    if (symbol == matrix[i, k])
                    {
                        int[] indexes = new int[2] { i, k };
                        output = $"({ string.Join(", ", indexes)})";
                        break;
                    }
                    else
                    {
                        output = $"{symbol} does not occur in the matrix";
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}
