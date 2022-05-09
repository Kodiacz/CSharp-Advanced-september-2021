using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string make, string model, int horsePower, string registraionNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registraionNumber;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public new string ToString()
        {
            string text = $"Make: {Make}\nModel: {Model}\nHorsePower: {HorsePower}\nRegstrationNumber: {RegistrationNumber}";
            return text;
        }
    }
}
