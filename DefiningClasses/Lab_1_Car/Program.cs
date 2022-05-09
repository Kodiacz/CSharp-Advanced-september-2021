using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    class Engine1
    {
        public Engine1(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
    }

    class Tire1
    {
        public Tire1(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        public int Year { get; set; }
        public double Pressure { get; set; }
    }
    class Car1
    {
        public Car1(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine1 engine, Tire1[] tires)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            Engine = engine;
            Tire = tires;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine1 Engine { get; set; }
        public Tire1[] Tire { get; set; }
        public void Drive(double distance)
        {
            double result = FuelQuantity - (distance * FuelConsumption / 100);
            if (result > 0)
            {
                FuelQuantity = result;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nHorsePowers: {this.Engine.HorsePower}\nFuelQuantity: {this.FuelQuantity}";

        }
    }
    class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Tire1[]> allTires = new List<Tire1[]>();
            List<Engine1> allEngines = new List<Engine1>();
            List<Car1> cars = new List<Car1>();
            List<double> presureSum = new List<double>();

            while (command != "No more tires")
            {
                // even = year, odd = pressure
                string[] tiresInformation = command.Split();
                List<int> years = new List<int>();
                List<double> pressures = new List<double>();
                for (int i = 0; i < tiresInformation.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        years.Add(int.Parse(tiresInformation[i]));
                    }
                    else
                    {
                        pressures.Add(double.Parse(tiresInformation[i]));
                    }
                }

                allTires.Add(new Tire1[4]
                {
                    new Tire1(years[0], pressures[0]),
                    new Tire1(years[1], pressures[1]),
                    new Tire1(years[2], pressures[2]),
                    new Tire1(years[3], pressures[3]),

                });

                presureSum.Add(pressures[0] + pressures[1] + pressures[2] + pressures[3]);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "Engines done")
            {
                string[] enginesInformation = command.Split();
                int horsePowers = int.Parse(enginesInformation[0]);
                double cubicCapacities = double.Parse(enginesInformation[1]);

                allEngines.Add(new Engine1(horsePowers, cubicCapacities));

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "Show special")
            {
                string[] carInformation = command.Split();
                string make = carInformation[0];
                string model = carInformation[1];
                int year = int.Parse(carInformation[2]);
                double fuelQuantity = double.Parse(carInformation[3]);
                double fuelConsumption = double.Parse(carInformation[4]);
                int engine = int.Parse(carInformation[5]);
                int tires = int.Parse(carInformation[6]);
                cars.Add(new Car1(make, model, year, fuelQuantity, fuelConsumption, allEngines[engine], allTires[tires]));

                command = Console.ReadLine();
            }

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Year >= 2017 && cars[i].Engine.HorsePower > 330 && (presureSum[i] >= 9 && presureSum[i] <= 10))
                {
                    cars[i].Drive(20);
                    Console.WriteLine(cars[i].WhoAmI());
                }
            }
        }
    }
}
