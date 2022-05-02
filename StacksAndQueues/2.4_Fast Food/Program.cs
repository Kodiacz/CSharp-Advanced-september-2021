using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._4_Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int biggestOrder = -1;
            Queue<int> queueForOrders = new Queue<int>();

            for (int i = 0; i < orders.Length; i++)
            {
                queueForOrders.Enqueue(orders[i]);
            }

            for (int i = 0; i < orders.Length; i++)
            {
                if (foodQuantity >= queueForOrders.Peek())
                {
                    if (queueForOrders.Peek() > biggestOrder)
                    {
                        biggestOrder = queueForOrders.Peek();
                    }

                    foodQuantity -= queueForOrders.Dequeue();
                }
            }

            Console.WriteLine(biggestOrder);

            if (queueForOrders.Count > 0)
            {
                while (queueForOrders.Count > 0)
                {
                    Console.WriteLine($"Orders left: {queueForOrders.Dequeue()}");
                }
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
