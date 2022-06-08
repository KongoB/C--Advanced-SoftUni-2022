using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {

        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {

            this.capacity = capacity;
            this.cars = new List<Car>();

        }

        public int Count => this.cars.Count;


        public string AddCar(Car car)
        {

            if (this.cars.Any(c => c.RegistratioNumber == car.RegistratioNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (this.cars.Count == this.capacity)
            {
                return "Parking is full!";
            }

            this.cars.Add(car);

            return $"Successfully added new car {car.Make} {car.RegistratioNumber}";

        }

        public string RemoveCar(string registrationNumber)
        {

            Car car = this.cars.FirstOrDefault(c => c.RegistratioNumber == registrationNumber);

            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }

            cars.Remove(car);
            return $"Successfully removed {registrationNumber}";

        }

        public Car GetCar(string registrationNumber)
        {
            Car car = cars.FirstOrDefault(x => x.RegistratioNumber == registrationNumber);

            return car;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {

            this.cars = this.cars.Where(c => !registrationNumbers.Contains(c.RegistratioNumber)).ToList();

        }

        

    }

}
