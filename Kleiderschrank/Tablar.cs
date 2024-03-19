using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Kleiderschrank
{
    internal class Tablar
    {
        public Tablar() 
        {
            Kleider = new List<Kleider>();
        }
        private List<Kleider> Kleider
        {
            get;
            set;
        }
        public void Add(Kleider Kleidungsstück)
        {
            if (IsFull()) return;
            if (Kleidungsstück is Socken && Kleider[0] is Socken) Kleider.Add(Kleidungsstück);
            else if(Kleidungsstück is T_Shirts && Kleider[0] is T_Shirts) Kleider.Add(Kleidungsstück);
            else if(Kleidungsstück is Hosen && Kleider[0] is Hosen) Kleider.Add(Kleidungsstück);
            else if(Kleidungsstück is Pullover && Kleider[0] is Pullover) Kleider.Add(Kleidungsstück);
            return;
        }
        public bool Remove(Kleider Kleidungsstück)
        {
            if(Kleider.Remove(Kleidungsstück))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFull()
        {
            if (Kleider[0] is Socken && Kleider.Count == 10)
            {
                return true;
            }
            else if (Kleider[0] is T_Shirts && Kleider.Count == 8)
            {
                return true;
            }
            else if (Kleider[0] is Hosen && Kleider.Count == 4)
            {
                return true;
            }
            else if (Kleider[0] is Pullover && Kleider.Count == 2)
            {
                return true;
            }
            return false;
        }
    }
}
