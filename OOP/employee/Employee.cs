using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_Employee
{
    internal class Employee
    {
        public string name;
        public int age;
        public int salary;

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary}");
        }

        public void PrintInfo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"Name: {name}");
            }
        }
    }
}