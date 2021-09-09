using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotNetFoundationSemechev
{
    class SingleLinkedList : IEnumerable<int>
    {
        public Node head;
        public Node tail;

        public int Count { get { return count; } }

        int count;

        public void Add(int data)
        {
            Node node = new Node(data, null);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public void InsertByIndex(int data, int pos)
        {
            Node node = new Node(data, null);

            Node current = head;

            for (int i = 0; i < pos - 2; i++)
            {
                current = current.Next;
            }

            node.Next = current.Next;
            current.Next = node;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
