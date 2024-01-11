using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB06.Haustierverwaltung_2
{
    internal class Cat : Pet
    {
        private static List<Cat> _list;
        static Cat()
        {
            List = new List<Cat>();
        }
        public Cat(string name, int age) : base(name,age)
        {
            List.Add(this);
        }
        public static List<Cat> List { get; set; }
        public static string ListToString()
        {
            string catString = string.Empty;
            foreach (Cat c in Cat.List)
            {
                catString += c.Name + "\t" + c.Age + Environment.NewLine;
            }
            return catString;
        }
    }
}
