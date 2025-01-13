using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB09.VererbungBeispiel
{
    public class Medium
    {
        public Medium(string title = "hallo") {
            Title = title;
        }

        private string Title { get; set; }

        public string Print()
        {
            return Title;
        }

        //public bool Equals(object obj)
        //{
        //    if (obj == null) return false;
          

        //}

     
    }
}
