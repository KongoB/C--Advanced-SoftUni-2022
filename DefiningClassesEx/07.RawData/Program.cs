using System;
using System.Collections.Generic;

namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();


            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                int inputTireCount = 5;

                Engine engine = new Engine(engineSpeed, enginePower);

                List<Tire> tires = new List<Tire>();

                for (int j = 0; j < 4; j++)
                {

                    Tire tire = new Tire(double.Parse(input[inputTireCount]), int.Parse(input[inputTireCount + 1]));

                    tires.Add(tire);
                    inputTireCount += 2;
                }

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car currentCar = new Car(model, engine, cargo, tires);

                cars.Add(currentCar);
            }


            string inputCargoType = Console.ReadLine();

            if (inputCargoType == "fragile")
            {
                foreach (var car in cars)
                {
                    bool pressureBelow1 = false;
                    foreach (var tire in car.Tires)
                    {
                        if (tire.TirePressure < 1)
                        {
                            pressureBelow1 = true;
                        }
                    }

                    if (car.Cargo.CargoType == "fragile" && pressureBelow1)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                foreach (var car in cars)
                {
                    if (inputCargoType == "flamable" && car.Engine.EnginePower > 250)
                    {

                        Console.WriteLine(car.Model);

                    }

                }
            }
        }
    }
}
