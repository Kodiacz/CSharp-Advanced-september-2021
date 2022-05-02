using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._7_TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> petrolAmount = new Queue<int>();
            Queue<int> distance = new Queue<int>();

            //int[] petrolAmount = new int[n];
            //int[] distance = new int[n];

            int difference = 0;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                petrolAmount.Enqueue(input[0]);
                distance.Enqueue(input[1]);

                //petrolAmount[i] = input[0];
                //distance[i] = input[1];
            }

            for (int i = 0; i < n; i++)
            {
                difference += petrolAmount.Peek() - distance.Peek();
                petrolAmount.Enqueue(petrolAmount.Dequeue());
                distance.Enqueue(distance.Dequeue());

                if (difference < 0)
                {
                    index++;
                    difference = 0;
                    i = 0;
                }

            }

            Console.WriteLine(index);
        }
    }
}
