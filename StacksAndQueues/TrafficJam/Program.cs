using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsThatCanPassOnGreen = int.Parse(Console.ReadLine());
            int totalPassedCars = 0;
            Queue<string> cars = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "green" && input != "end")
                {
                    cars.Enqueue(input);
                }

                if (input == "green")
                {
                    for (int i = 0; i < carsThatCanPassOnGreen; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }

                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        totalPassedCars++;
                    }
                }
                else if (input == "end")
                {
                    Console.WriteLine($"{totalPassedCars} cars passed the crossroads.");
                    break;
                }
            }
        }
    }
}
