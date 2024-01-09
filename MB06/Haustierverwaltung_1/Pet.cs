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
        public Pet(string name,int age, bool cat, bool dog) 
        {
            Name = name;
            Age = age;
            if (dog)
            {
                Animal = "dog";
            }
            if (cat)
            {
                Animal = "cat";
            }
            Count++;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Animal { get;set;}
        public static int Count { get; set; }
    }
}
