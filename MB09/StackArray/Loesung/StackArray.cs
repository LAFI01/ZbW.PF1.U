using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB09.StackArray.Loesung
{
    internal class StackArray
    {
        private object[] items;

        public int Count { get; private set; }

        public StackArray(int length = 0)
        {
            items = new object[length == 0 ? 10 : length];
        }

        public void Push(object item)
        {
            grow();

            items[Count] = item;

            Count++;
        }

        public object Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items on stack.");

            return items[Count - 1];
        }

        public object Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items on stack.");

            object item = items[Count - 1];
            items[Count - 1] = default;
            Count--;

            return item;
        }

        public void Clear()
        {
            items = new object[10];
            Count = 0;
        }

        private void grow()
        {
            // Überprüfen, ob noch Platz
            if (items.Length >= Count + 1)
                return;

            // Array-Kapazität verdoppeln
            int newLength = items.Length * 2;

            Array.Resize(ref items, newLength);
        }
    }
}

