using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB06.Haustierverwaltung_1
{
    internal class Cat
    {
        public Cat() { }
        public Cat(string name, int age) 
        {
            Name= name;
            Age = age;
        }
        private string Name { get; set; }
        private int Age { get; set; }
    }
}
