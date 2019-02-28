using System;
using System.Collections.Generic;

namespace Speed_Racing
{
    class Car
    {
        public Car()
        {
            TravelDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelDistance { get; set; }

        public static void MoveACar( Car car, double distanceInKilometers)
        {
            if (distanceInKilometers*car.FuelConsumptionPerKilometer > car.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");                
            }
            else
            {
                car.FuelAmount -= distanceInKilometers * car.FuelConsumptionPerKilometer;
                car.TravelDistance += distanceInKilometers;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int CarsToTrack = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < CarsToTrack; i++)
            {
                string[] inputCars = Console.ReadLine().Split();

                Car car = new Car();

                car.Model = inputCars[0];
                car.FuelAmount = double.Parse(inputCars[1]);
                car.FuelConsumptionPerKilometer = double.Parse(inputCars[2]);

                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();

                for (int i = 0; i < cars.Count; i++)
                {
                    if (command[1] == cars[i].Model)
                    {
                        Car.MoveACar(cars[i],double.Parse(command[2]));
                    }
                }

                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelDistance}");
            }
        }
    }
}
