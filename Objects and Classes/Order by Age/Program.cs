using System;
using System.Collections.Generic;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                Person person = new Person();
                person.name = input[0];
                person.ID = input[1];
                person.age = int.Parse(input[2]);

                people.Add(person);


                input = Console.ReadLine().Split();
            }

            people.Sort((x, y) => x.age.CompareTo(y.age));

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{people[i].name} with ID: {people[i].ID} is {people[i].age} years old.");
            }
        }
    }

    class Person
    {
        public string name { get; set; }
        public string ID { get; set; }
        public int age { get; set; }
    }
}
