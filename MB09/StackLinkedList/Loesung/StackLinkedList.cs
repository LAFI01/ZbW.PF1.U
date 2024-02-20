using MB09.Loesung.SinglyLinkedListExample;

namespace MB09.StackLinkedList.Loesung
{
    public class StackLinkedList
    {
        private SinglyLinkedList items;

        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        public StackLinkedList()
        {
            items = new SinglyLinkedList(); ;
        }

        public void Push(object item)
        {
            items.Add(item);

        }

        public object Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items in stack.");

            var ret = items[items.Count - 1];
            items.Remove(ret);

            return ret;
        }

        public object Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items in queue.");

            return items[items.Count - 1];
        }
    }
}
