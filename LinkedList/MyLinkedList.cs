using System;

namespace the_ultimate_data_structures_and_algorithms.LinkedList
{
    public class MyLinkedList
    {
        private class MyNode
        {
            public int value;
            public MyNode next;

            public MyNode(int value)
            {
                this.value = value;
            }
        }

        private MyNode first;
        private MyNode last;

        public void addLast(int item)
        {
            var node = new MyNode(item);

            if (isEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }

        public void addFirst(int item)
        {
            var node = new MyNode(item);

            if (isEmpty())
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }
        }

        public int indexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool contains(int item)
        {
            return indexOf(item) != -1;
        }

        public void removeFirst()
        {
            if (isEmpty())
                throw new Exception();

            if (first == last)
            {
                first = last = null;
                return;
            }

            var second = first.next;
            first.next = null;
            first = second;
        }

        private bool isEmpty()
        {
            return first == null;
        }
    }
}