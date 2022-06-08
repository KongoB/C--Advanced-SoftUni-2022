using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Car
    {

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tires { get; set; }

    }

    public class Engine
    {

        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }

    }

    public class Cargo
    {

        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get; set; }

        public string CargoType { get; set; }

    }

    public class Tire
    {

        public Tire(double tirePressure, int tireAge)
        {
            
            TirePressure = tirePressure;
            TireAge = tireAge;
        }


        public double TirePressure { get; set; }

        public int TireAge { get; set; }

    }

}
