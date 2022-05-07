using System;
using System.Collections.Generic;

namespace Lab_6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {

                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = input[0];

                if (direction == "END")
                {
                    break;
                }

                string carNumber = input[1];

                switch (direction)
                {
                    case "IN":
                        cars.Add(carNumber);
                        break;
                    case "OUT":
                        cars.Remove(carNumber);
                        break;
                }
            }

            if (cars.Count > 0)
            {
                Console.WriteLine(string.Join("\n", cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
