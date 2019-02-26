using System;
using System.Collections.Generic;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VechicleCatalogue cataloge = new VechicleCatalogue();

            while (input != "end")
            {
                string[] info = input.Split('/');

                if (info[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = info[1];
                    car.Model = info[2];
                    car.HorsePower = int.Parse(info[3]);

                    cataloge.Cars.Add(car);
                }
                else if (info[0] == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = info[1];
                    truck.Model = info[2];
                    truck.Weight = int.Parse(info[3]);
                    cataloge.Trucks.Add(truck);
                }
                input = Console.ReadLine();
            }

            cataloge.Cars.Sort((x, y) =>x.Brand.CompareTo(y.Brand));
            cataloge.Trucks.Sort((x, y) => x.Brand.CompareTo(y.Brand));

            if (cataloge.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in cataloge.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (cataloge.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in cataloge.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class VechicleCatalogue
    {
        public VechicleCatalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
