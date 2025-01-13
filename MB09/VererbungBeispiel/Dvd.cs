using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB09.VererbungBeispiel
{
    public class Dvd : Medium
    {
        public Dvd(string title, string ressigeur) : base(title)
        {
            Ressigeur = ressigeur;
        }

        public string Ressigeur { get; set; }

        public string Print()
        {
            return base.Print() + "" + Ressigeur;
        }
    }
}
