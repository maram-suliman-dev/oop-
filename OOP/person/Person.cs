using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace program_person
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public void PrintInfo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }
    }
}