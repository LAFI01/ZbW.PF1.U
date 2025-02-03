using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MB09.VererbungBeispiel
{
    public class Cd : Medium
    {

        public Cd(string title, string kuenstler) : base(title) {

            Kuenstler= kuenstler;
        }

        public Cd(string mussNichtgleichSeinWieBasis) : base(mussNichtgleichSeinWieBasis)
        {

          
        }

        public string Kuenstler {  get; set; }

        public string Print()
        {
            
            string value = Kuenstler + " " + base.Print();
  
            return value;
        }
    }
}
