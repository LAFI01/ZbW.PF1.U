using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB09.DoublyLinkedListExample
{
    internal class Node
    {
        public object Data { get; set; }
        public Node Link { get; set; }
        public Node PrevLink { get; set; }
    }
}
