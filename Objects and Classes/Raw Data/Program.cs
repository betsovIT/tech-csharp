using System;
using System.Collections.Generic;

namespace Raw_Data
{
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Cargo
    {
        public string Type { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public Car()
        {
            Engine = new Engine();
            Cargo = new Cargo();
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();

                Car car = new Car();
                car.Model = input[0];
                car.Engine.Speed = int.Parse(input[1]);
                car.Engine.Power = int.Parse(input[2]);
                car.Cargo.Weight = int.Parse(input[3]);
                car.Cargo.Type = input[4];

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Cargo.Type == "fragile" && cars[i].Cargo.Weight < 1000)
                    {
                        Console.WriteLine(cars[i].Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Cargo.Type == "flamable" && cars[i].Engine.Power > 250)
                    {
                        Console.WriteLine(cars[i].Model);
                    }
                }
            }

            
        }
    }
}
