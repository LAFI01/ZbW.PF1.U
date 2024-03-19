using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kleiderschrank
{
    internal class Kleider
    {
        public Kleider(float grösse, string farbe) 
        {
            Grösse = grösse;
            Farbe = farbe;
        }
        public float Grösse
        {
            get;
            set;
        }
        public string Farbe
        {
            get;
            set;
        }
    }
}
