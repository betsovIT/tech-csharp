using System;
using System.Collections.Generic;

namespace Oldest_Family_Member
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family
    {
        public Family()
        {
            people = new List<Person>();
        }

        public List<Person> people { get; set; }

        public void AddMember(Person member)
        {
            people.Add(member);
        }
        public Person GetOldestMember()
        {
            if (people.Count>0)
            {
                int age = int.MinValue;
                int personNumber = -1;
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Age > age)
                    {
                        age = people[i].Age;
                        personNumber = i;
                    }
                }
                return people[personNumber];
            }
            else
            {
                return null;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int members = int.Parse(Console.ReadLine());

            for (int i = 0; i < members; i++)
            {
                Person person = new Person();

                string[] input = Console.ReadLine().Split();

                person.Name = input[0];
                person.Age = int.Parse(input[1]);

                family.AddMember(person);
            }

            Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
        }
    }

}
