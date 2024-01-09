using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB05.HandtaschenBeispiel
{    public class Handtasche
    {
        string name;
        decimal price;
        public Handtasche(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
