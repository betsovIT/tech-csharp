using System;
using System.Collections.Generic;

namespace Vehicle_Catalogue___Е
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vechicle> catalogue = new List<Vechicle>();

            List<string> toDisplay = new List<string>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] info = input.Split();

                Vechicle vechicle = new Vechicle();
                vechicle.type = info[0];
                vechicle.model = info[1];
                vechicle.color = info[2];
                vechicle.horsePower = int.Parse(info[3]);

                catalogue.Add(vechicle);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                toDisplay.Add(input);
                input = Console.ReadLine();
            }

            int sumCarHP = 0;
            int sumTruckHP = 0;
            int sumCars = 0;
            int sumTrucks = 0;
            double avCarHP = 0;
            double avTruckHP = 0;

            for (int i = 0; i < catalogue.Count; i++)
            {
                if (catalogue[i].type == "car")
                {
                    sumCarHP += catalogue[i].horsePower;
                    sumCars++;
                }
                else if (catalogue[i].type == "truck")
                {
                    sumTruckHP += catalogue[i].horsePower;
                    sumTrucks++;
                }
            }
            if (sumCars > 0) avCarHP = sumCarHP / (double)sumCars;
            if (sumTrucks > 0) avTruckHP = sumTruckHP / (double)sumTrucks;

            for (int i = 0; i < toDisplay.Count; i++)
            {
                for (int j = 0; j < catalogue.Count; j++)
                {
                    if (catalogue[j].model == toDisplay[i])
                    {
                        Console.WriteLine($"Type: {char.ToUpper(catalogue[j].type[0])+ catalogue[j].type.Substring(1)}");
                        Console.WriteLine($"Model: {catalogue[j].model}");
                        Console.WriteLine($"Color: {catalogue[j].color}");
                        Console.WriteLine($"Horsepower: {catalogue[j].horsePower}");
                    }
                }
            }

            Console.WriteLine($"Cars have average horsepower of: {avCarHP:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avTruckHP:F2}.");

        }
    }
    class Vechicle
    {
        public string type { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public int horsePower { get; set; }
    }
}
