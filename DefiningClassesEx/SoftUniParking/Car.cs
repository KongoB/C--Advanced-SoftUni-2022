﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistratioNumber = registrationNumber;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public string RegistratioNumber { get; set; }


        public override string ToString()
        {
            string res = $"Make: {Make}" + Environment.NewLine;
            res += $"Model: {Model}" + Environment.NewLine;
            res += $"HorsePower: {HorsePower}" + Environment.NewLine;
            res += $"RegistrationNumber: {RegistratioNumber}";

            return res;
        }

    }
}
