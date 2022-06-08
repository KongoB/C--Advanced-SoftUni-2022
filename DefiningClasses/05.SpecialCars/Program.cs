using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Tire[]> listOfTires = new List<Tire[]>();
            List<Engine> listOfEngines = new List<Engine>();
            List<Car> listOfCars = new List<Car>();

            string command = Console.ReadLine();

            while (command != "No more tires")
            {
                string[] tirePressureInput = command.Split();
                int[] tireYear = new int[4];
                double[] tirePressure = new double[4];
                int j = 0;
                for (int i = 0; i < 8; i++)
                {
                    tireYear[j] = int.Parse(tirePressureInput[i]);
                    tirePressure[j] = double.Parse(tirePressureInput[i + 1]);
                    j++;
                    i++;
                }

                listOfTires.Add(new Tire[4]
                {
                    new Tire(tireYear[0], tirePressure[0]),
                    new Tire(tireYear[1], tirePressure[1]),
                    new Tire(tireYear[2], tirePressure[2]),
                    new Tire(tireYear[3], tirePressure[3]),
                });
                command = Console.ReadLine();
            }

            string[] enginePowerInput = Console.ReadLine().Split();     //!

            while (enginePowerInput[0] != "Engines")
            {
                int horsePower = int.Parse(enginePowerInput[0]);
                double engineLeters = double.Parse(enginePowerInput[1]);

                listOfEngines.Add(new Engine (horsePower, engineLeters));
                enginePowerInput = Console.ReadLine().Split();
            }

            string[] newCarInput = Console.ReadLine().Split();
            while (newCarInput[0] != "Show")
            {
                listOfCars.Add(new Car(newCarInput[0],
                    newCarInput[1],
                    int.Parse(newCarInput[2]),
                    double.Parse(newCarInput[3]),
                    double.Parse(newCarInput[4]),
                    listOfEngines[int.Parse(newCarInput[5])],
                    listOfTires[int.Parse(newCarInput[6])]
                    ));
                newCarInput = Console.ReadLine().Split();
            }

            foreach (var car in listOfCars)
            {
                if (listOfCars.Any())
                {
                    double tirePressure = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        tirePressure += car.Tires[i].Pressure;
                    }

                    if (car.Drive(20) && car.Year >= 2017 && car.Engine.HorsePower > 330 && tirePressure >= 9 && tirePressure <= 10)
                    {
                        StringBuilder builder = new StringBuilder();

                        builder.AppendLine($"Make: {car.Make}");
                        builder.AppendLine($"Model: {car.Model}");
                        builder.AppendLine($"Year: {car.Year.ToString()}");
                        builder.AppendLine($"HorsePowers: {car.Engine.HorsePower.ToString()}");
                        builder.AppendLine($"FuelQuantity: {car.FuelQuantity.ToString()}");

                        Console.Write(builder);
                    }
                }
            }


        }
    }
}
