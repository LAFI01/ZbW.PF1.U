using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB06.Haustierverwaltung_2
{
    internal class Dog : Pet
    {
        private static List<Dog> _list;
        static Dog()
        {
            List = new List<Dog>();
        }
        public Dog(string name, int age) : base(name, age)
        {
            List.Add(this);
        }
        public static List<Dog> List{get; set; }
        public static string ListToString()
        {
            string dogString = string.Empty;
            foreach (Dog d in Dog.List)
            {
                dogString += d.Name + "\t" + d.Age + Environment.NewLine;
            }
            return dogString;
        }
    }
}
