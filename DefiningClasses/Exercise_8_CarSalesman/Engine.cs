﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8_CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power, int displacement, string efficiancy)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiancy;
        }
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
