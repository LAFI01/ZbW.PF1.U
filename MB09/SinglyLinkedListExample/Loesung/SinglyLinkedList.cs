
namespace MB09.Loesung.SinglyLinkedListExample
{
    public class SinglyLinkedList
    {
        private Node start;
        private Node end;

        public int Count { get; private set; }

        #region Aufgabe 1: Add-Methode
        public void Add(object data)
        {
            var newItem = new Node() { Data = data, Link = null };

            if (start == null)
            {
                start = newItem;
                end = newItem;
            }
            else
            {
                end.Link = newItem;
                end = newItem;
            }
            Count++;
        }
        #endregion

        #region Aufgabe 2: Contains-Methode
        public bool Contains(object data)
        {
            return Find(data) != null;
        }

        private Node Find(object data)
        {
            var node = start;

            while (node != null)
            {
                if (node.Data.Equals(data))
                {
                    return node;
                }

                node = node.Link;
            }
            return null;
        }
        #endregion

        #region Aufgabe 3: Remove-Methode
        public bool Remove(object data)
        {
            var node = Find(data);

            if (node == null)
            {
                return false;
            }
            var previousNode = FindPrevious(data);

            if (previousNode != null)
            {
                // aus Mitte oder Ende entfernen
                previousNode.Link = node.Link;
                if (node == end)
                {
                    end = previousNode;
                }
            }
            else
            {
                // ersten entfernen, previousNode == null
                start = node.Link;
                if (start == null)
                {
                    // Liste leer
                    end = null;
                }
            }

            Count--;

            return true;
        }

        private Node FindPrevious(object data)
        {
            Node previousNode = null;
            var node = start;

            while (node != null)
            {
                if (node.Data.Equals(data))
                {
                    return previousNode;
                }

                previousNode = node;
                node = node.Link;
            }
            return null;
        }
        #endregion

        #region Aufgabe 4: Find-Methode
        public object FindByIndex(int index)
        {
            return FindByIndexInternal(index)?.Data;
        }

        private Node FindByIndexInternal(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            var node = start;
            var i = 0;

            while (node != null)
            {
                if (i == index)
                {
                    return node;
                }
                node = node.Link;
                i++;
            }
            return null;
        }
        #endregion

        #region Aufgabe 5: Indexer
        public object this[int index]
        {
            get { return this.FindByIndexInternal(index)?.Data; }
            set
            {
                var node = this.FindByIndexInternal(index);
                if (node != null)
                {
                    node.Data = value;
                }
            }
        }
        #endregion
    }
}
