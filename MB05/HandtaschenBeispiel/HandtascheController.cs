using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB04.HandtaschenBeispiel
{
    internal class HandtascheController
    {
        Handtasche handtasche;
        public HandtascheController(string name, decimal price) 
        {
            Handtasche handtasche = new Handtasche(name, price);
        }
        
    }
}
