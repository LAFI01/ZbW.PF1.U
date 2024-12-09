using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB06
{
    public class BicycleV2
    {
        private int _weight;

        public Color Color { get; set; }

        public string Print()
        {
            return $"Das Gewicht ist: {Weight} und die Farbe ist: {Color}";
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }
    }
}
