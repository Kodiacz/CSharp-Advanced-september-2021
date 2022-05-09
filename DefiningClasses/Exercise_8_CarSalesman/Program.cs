using System;
using System.Collections.Generic;

namespace Exercise_8_CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < engineCount; i++)
            {
                string[] engineInfo = Console.ReadLine().Split();
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                int displacement = 0;
                string efficiency = "n/a";

                if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out displacement))
                    {
                        displacement = int.Parse(engineInfo[2]);
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    displacement = int.Parse(engineInfo[2]);
                    efficiency = engineInfo[3];
                }

                engines.Add(model, new Engine(model, power, displacement, efficiency));
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                string engine = carInfo[1];
                int weight = 0;
                string color = "n/a";

                if (carInfo.Length == 3)
                {
                    if (int.TryParse(carInfo[2], out weight))
                    {
                        weight = int.Parse(carInfo[2]);
                    }
                    else
                    {
                        color = carInfo[2];
                    }
                }
                else if (carInfo.Length == 4)
                {
                    weight = int.Parse(carInfo[2]);
                    color = carInfo[3];
                }

                cars.Add(new Car(model, engines[engine], weight, color));
            }

            foreach (var car in cars)
            {
                string text = "n/a";
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($" {car.Engine.Model}:");
                Console.WriteLine($"  Power: {car.Engine.Power}");
                Console.WriteLine($"  Displacement: {(car.Engine.Displacement == 0 ? $"n/a" : $"{car.Engine.Displacement}")}");
                Console.WriteLine($"  Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($" Weight: {(car.Weight == 0 ? $"n/a" : $"{car.Weight}")}");
                Console.WriteLine($" Color: {car.Color}");
            }
        }
        
    } 
}