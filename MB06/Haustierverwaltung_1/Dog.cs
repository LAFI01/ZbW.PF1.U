using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MB06.Haustierverwaltung_1
{
    internal class Dog
    {
        public Dog() { }
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
        private string Name { get; set; }
        private int Age { get; set; }
    }
}
