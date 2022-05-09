using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6_SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //(Speed Racing):

            //int n = int.Parse(Console.ReadLine());
            //Dictionary<string, Car> cars = new Dictionary<string, Car>();
            //for (int i = 0; i < n; i++)
            //{
            //    string[] carInformation = Console.ReadLine().Split();
            //    string model = carInformation[0];
            //    double fuelAmount = double.Parse(carInformation[1]);
            //    double fuelConsumptionForPerKilometer = double.Parse(carInformation[2]);

            //    if (!cars.ContainsKey(model))
            //    {
            //        cars.Add(model, new Car(model, fuelAmount, fuelConsumptionForPerKilometer));
            //    }
            //}

            //while (true)
            //{
            //    string[] command = Console.ReadLine().Split();

            //    if (command[0] == "End")
            //    {
            //        break;
            //    }

            //    string model = command[1];
            //    double distance = double.Parse(command[2]);
            //    cars[model].Drive(distance);
            //}

            //foreach (var car in cars)
            //{
            //    Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:F2} {car.Value.TravelledDistance}");
            //}

            //(Raw Data): ---------------------------------------------------------------------------------------------------------------

            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split();
                string model = information[0];
                int engineSpeed = int.Parse(information[1]);
                int enginePower = int.Parse(information[2]);
                int cargoWeight = int.Parse(information[3]);
                string cargoType = information[4];
                double[] tirePressure = new double[] { double.Parse(information[5]), double.Parse(information[7]), double.Parse(information[9]), double.Parse(information[11]) };
                int[] tireAge = new int[] { int.Parse(information[6]), int.Parse(information[8]), int.Parse(information[10]), int.Parse(information[12]) };

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tires tires = new Tires(tireAge, tirePressure);

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                //foreach (var car in cars)
                //{
                //    for (int i = 0; i < car.Tires.Pressure.Length; i++)
                //    {
                //        if (car.Tires.Pressure[i] < 1)
                //        {
                //            Console.WriteLine(car.Model);
                //            break;
                //        }
                //    }
                //}

                List<Car> fragileCars = cars
                    .Where(x => x.Cargo.Type == command && x.Tires.Pressure.Any(t => t < 1))
                    .ToList();

                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flammable")
            {
                //foreach (var car in cars)
                //{
                //    if (car.Engine.Power > 250)
                //    {
                //        Console.WriteLine(car.Model);
                //    }
                //}

                List<Car> flammableCars = cars
                    .Where(x => x.Cargo.Type == command && x.Engine.Power > 250)
                    .ToList();

                foreach (var car in flammableCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
