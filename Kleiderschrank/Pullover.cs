using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kleiderschrank
{
    internal class Pullover : Kleider
    {
        internal Pullover(float Grösse, string Farbe, bool isHoodie) : base(Grösse, Farbe)
        {
            IsHoodie = isHoodie;
        }
        public bool IsHoodie
        {
            get; 
            set;
        }
    }
}
