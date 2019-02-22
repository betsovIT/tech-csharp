using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {student}, Age: {age}, Grade: {grade:F2}");
        }
    }
}
