using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB07.RezeptbuchBeispiel
{
    public class Rezept
    {
        public string Name { get; set; }
        public int Time { get; set; }

        public bool Equals(Rezept other)
        {
            if (other == null)
            {
                return false;
            }
            else if (Name == other.Name && Time == other.Time)
            {
                return true;
            }
            return false;
        }
    }
}
