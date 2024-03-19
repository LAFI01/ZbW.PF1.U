using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kleiderschrank
{
    internal class Kleiderschrank
    {
        internal Kleiderschrank() 
        {
            Tablare = new List<Tablar>();
            for(int i = 0; i < 5; i++)
            {
                Tablare.Add(new Tablar());
            }
        }
        public List<Tablar> Tablare
        {
            get;
            set;
        }
        public void Add(Kleider kleidungsstück)
        {
            foreach(Tablar tablar in Tablare)
            {
                if (!tablar.IsFull())
                {
                    tablar.Add(kleidungsstück);
                    return;
                }
            }
            throw new Exception("De Kleiderschrank isch voll, chauf en neue du löli");
        }
        public bool Remove(Kleider kleidungsstück)
        {
            foreach (Tablar tablar in Tablare)
            {
                if (tablar.Remove(kleidungsstück))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
