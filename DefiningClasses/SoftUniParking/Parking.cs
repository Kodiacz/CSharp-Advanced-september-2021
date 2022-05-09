using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        public Parking(int capacity)
        {
            Capacity = capacity;
        }
        public int Capacity { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();
        public int Count { get; set; } 
        public string AddCar(Car car)
        {
            string text = "";
            if (Cars.Contains(car))
            {
                text = "Car with that registration number, already exists!";
                
            }
            else if (Cars.Count > Capacity)
            {
                text = "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                Count++;
                text = $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }

            return text;
        }

        public string RemoveCar(string registrationNumber)
        {
            bool notExist = false;
            string text = "";

            foreach (var car in Cars)
            {

                if (car.RegistrationNumber == registrationNumber)
                {
                    Cars.Remove(car);
                    text = $"Successfully removed {registrationNumber}";
                    notExist = false;
                    Count--;
                    break;
                }
                else
                {
                    notExist = true;
                }
            }

            if (notExist)
            {
                text = "Car with that registration number, doesn't exist!";
            }

            return text;
        }

        public Car GetCar(string registrationNumber)
        {
            Car temp = new Car();
            foreach (var car in Cars)
            {
                if (car.RegistrationNumber == registrationNumber)
                {
                    temp = car;
                    break;
                }
            }

            return temp;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registration in registrationNumbers)
            {
                foreach (var car in Cars)
                {
                    if (car.RegistrationNumber == registration)
                    {
                        Cars.Remove(car);
                        Count--;
                    }
                }
            }
        }
    }
}
