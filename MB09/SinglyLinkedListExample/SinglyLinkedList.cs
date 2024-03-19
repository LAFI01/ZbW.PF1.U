using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace MB09.SinglyLinkedListExample
{
    public class SinglyLinkedList
    {
        private Node start;
        private Node end;

        public int Count { get; private set; }
        public void Add(Object data)
        {
            Node node = new Node();
            node.Data = data;
            node.Link = null;
            if (start == null)
            {
                start = node;
                end = node;
            }
            else
            {
                end.Link = node;
                end = node;
            }
            Count++;
        }
        public bool Contains(Object item)
        {
            if (start == null || end == null)
            {
                return false;
            }
            else
            {
               return Find(item) != null;
            }
        }
        private Node Find(Object data)
        {
            Node node = new Node();
            node.Data = start.Data;
            node.Link = start.Link;

            while (node != null)
            {
                if (node.Data.Equals(data))
                {
                    return node;
                }
                if(node.Link != null)
                {
                    node = node.Link;
                }
            }
            return null;
        }
        public bool Remove(Object item)
        {
            Node nodeToRemove = Find(item);

            if (nodeToRemove == null)
            {
                return false;
            }
            else if(nodeToRemove.Equals(start))
            {
                start = nodeToRemove.Link;
                Count--;
                return true;
            }

            Node previousNode = FindPreviousNode(nodeToRemove);
            if (previousNode != null)
            {
                previousNode.Link = nodeToRemove.Link;
            }

            if (nodeToRemove == end)
            {
                end = previousNode;
            }
            Count--;
            return true;
        }
        public Node FindPreviousNode(Node item)
        {
            Node node = start;

            while (node.Link != null)
            {
                if(node.Link == item.Link)
                {
                    return node;
                }
                node = node.Link;
            }
            return null;
        }
        public bool FindByIndex(int index)
        {
            return false;
        }
    }
}
