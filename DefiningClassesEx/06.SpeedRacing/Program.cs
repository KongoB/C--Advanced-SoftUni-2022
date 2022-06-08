using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Car[] cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);

                cars[i] = new Car(model, fuelAmount, fuelConsumptionFor1km);
            }

            

            string[] input = Console.ReadLine().Split();

            while (input[0] == "Drive")
            {

                string model = input[1];
                double travelDistance = double.Parse(input[2]);

                Car car = cars.FirstOrDefault(c => c.Model == model);

                car.Drive(travelDistance);

                input = Console.ReadLine().Split();
            }

            foreach (var car in cars)
            {

                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");

            }


        }
    }
}
