using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB06.Person_static
{
    public class Person
    {
        private string _firstname;
        private string _name;
        private int _age;

        public Person() { }
        public Person(string firstname, string name, int age)
        {
            FirstName = firstname;
            Name = name;
            Age = age;
            Id++;
        }

        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public static int Id { get; set; }
    }
}
