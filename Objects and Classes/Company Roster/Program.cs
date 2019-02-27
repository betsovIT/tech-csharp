using System;
using System.Collections.Generic;

namespace Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int toRead = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();

            for (int i = 0; i < toRead; i++)
            {
                string[] input = Console.ReadLine().Split();

                bool foundDepartment = false;

                Employee employee = new Employee();
                employee.Name = input[0];
                employee.Salary = double.Parse(input[1]);
                employee.Department = input[2];

                for (int j = 0; j < departments.Count; j++)
                {
                    if (employee.Department == departments[j].Name)
                    {
                        departments[j].Employees.Add(employee);
                        foundDepartment = true;
                        break;
                    }
                }

                if (!foundDepartment)
                {
                    Department department = new Department();
                    department.Name = input[2];
                    department.Employees.Add(employee);
                    departments.Add(department);
                }
            }
            double maxAvSalary = 0;
            string richestDepartment = "";

            for (int i = 0; i < departments.Count; i++)
            {
                double sumSalary = 0;
                for (int k = 0; k < departments[i].Employees.Count; k++)
                {
                    sumSalary += departments[i].Employees[k].Salary;
                }

                if (sumSalary > maxAvSalary)
                {
                    maxAvSalary = sumSalary;
                    richestDepartment = departments[i].Name;
                }
            }

            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].Name == richestDepartment)
                {
                    Console.WriteLine($"Highest Average Salary: {departments[i].Name}");
                    departments[i].Employees.Sort((x, y) => x.Salary.CompareTo(y.Salary));
                    departments[i].Employees.Reverse();

                    for (int j = 0; j < departments[i].Employees.Count; j++)
                    {
                        Console.WriteLine($"{departments[i].Employees[j].Name} {departments[i].Employees[j].Salary:F2}");
                    }
                }
            }
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
    class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        
    }
}
