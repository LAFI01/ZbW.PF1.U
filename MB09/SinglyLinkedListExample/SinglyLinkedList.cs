using System.ComponentModel.Design;

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

            do
            {
                if (node.Data == data)
                {
                    return node;
                }
                node = node.Link;
            } while (node.Link != null);
            return null;
        }
        public bool Remove(Object item)
        {
            Node nodeToRemove = Find(item);

            if (nodeToRemove == null)
            {
                return false;
            }
            else if(nodeToRemove == start)
            {
                start = nodeToRemove.Link;
                return true;
            }
            Node node = new Node();
            Node previousNode = FindPreviousNode(nodeToRemove);
            previousNode.Link = nodeToRemove.Link;



            //if(previousNode == start)
            //{
            //    start.Link = nodeToRemove.Link;
            //}
            if (nodeToRemove == end)
            {
                end = previousNode;
            }
            return true;
        }
        public Node FindPreviousNode(Object item)
        {
            Node node = start;

            while (node.Link != null)
            {
                if(node.Link == item)
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
