using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB06.Haustierverwaltung_1
{
    internal class Pet
    {

        public Pet() { }
        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
            Count++;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public static int Count { get; set; }
    }
}
