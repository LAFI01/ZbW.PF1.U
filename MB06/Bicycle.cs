using System.Drawing;

namespace MB06
{
    public class Bicycle
    {
        private int _weight;

        private string _color;

        public Bicycle(int weight, string color)
        {
            Weight = weight;
            Color = color;
        }

        public Bicycle(int weight) : this (weight, "schwarz")
        {
            //Weight = weight;
            //Color = "schwarz";
        }

        public Bicycle() : this (10, "schwarz")
        {
            //Weight = 10;
            //Color = "schwarz";
        }

        public string Color { get; set; }

        public string Print()
        {
            return $"Das Gewicht ist: {Weight} und die Farbe ist: {_color}";
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

        public void SetWeight(int weight)
        {
            //if (weight > 0)
            // {
            _weight = weight;
            // }
        }

        public int GetWeight()
        {
            return _weight;
        }

    }
}
