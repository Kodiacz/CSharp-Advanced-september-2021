using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._2_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int sumOfValues = 0;
            Stack<int> clothes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                clothes.Push(input[i]);
            }

            while (clothes.Count > 0)
            {
                sumOfValues += clothes.Peek();

                if (sumOfValues < capacity)
                {
                    clothes.Pop();
                }
                else if (sumOfValues == capacity)
                {
                    if (clothes.Count == 1 && clothes.Peek() == capacity)
                    {
                        sumOfValues = 0;
                        clothes.Pop();
                        continue;
                    }

                    sumOfValues = 0;
                    clothes.Pop();
                    racks++;
                }
                else if (sumOfValues > capacity)
                {
                    sumOfValues = 0;
                    racks++;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
