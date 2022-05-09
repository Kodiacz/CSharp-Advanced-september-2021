using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_6_SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public Car(string model, Engine engine, Cargo cargo, Tires tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; } = 0;
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires Tires { get; set; }
        public void Drive(double kilometers)
        {
            if ((FuelAmount - kilometers * FuelConsumptionPerKilometer) >= 0)
            {
                FuelAmount -= kilometers * FuelConsumptionPerKilometer;
                TravelledDistance += kilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
