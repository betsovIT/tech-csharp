using System;
using System.Collections.Generic;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] info = input.Split();

                Box box = new Box();
                box.SerialNumber = info[0];
                box.Item.Name = info[1];
                box.ItemQuantity = int.Parse(info[2]);
                box.Item.Price = double.Parse(info[3]);
                box.PriceForABox = box.Item.Price * box.ItemQuantity;

                boxes.Add(box);
                input = Console.ReadLine();
            }
            boxes.Sort((x,y) => x.PriceForABox.CompareTo(y.PriceForABox));
            boxes.Reverse();
            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }
    }
}
