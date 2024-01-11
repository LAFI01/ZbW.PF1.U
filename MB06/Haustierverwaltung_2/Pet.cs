using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MB06.Haustierverwaltung_2
{
    internal class Pet
    {
        private static List<Pet> _list;
        static Pet() 
        {
            List = new List<Pet>();
        }
        public Pet() { }
        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
            Count++;
            List.Add(this);
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public static int Count { get; set; }
        public static List<Pet> List
        {
            get; set;
        }
        public static string ListToString()
        {
            string petString = string.Empty;
            foreach (Pet p in Pet.List)
            {
                petString += p.Name + " says" + "\t\t" + "Wuhuu, ";
                if (p.GetType() == typeof(Dog))
                {
                    petString += "Wuuf" + Environment.NewLine;
                }
                else if(p.GetType() == typeof(Cat))
                {
                    petString += "Miau" + Environment.NewLine;
                }
            }
            return petString;
        }
    }
}