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
        private int count;

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

            count++;
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

            count++;
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
                first = last = null;
            else
            {
                var second = first.next;
                first.next = null;
                first = second;
            }

            count--;
        }

        public void removeLast()
        {
            if (isEmpty())
                throw new Exception();

            if (first == last)
                first = last = null;
            else
            {
                var previous = getPrevious(last);
                last = previous;
                last.next = null;
            }

            count--;
        }

        public int size()
        {
            return count;
        }

        public int[] toArray()
        {
            int[] array = new int[count];
            var current = first;

            var index = 0;
            while (current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }

            return array;
        }

        public void reverse()
        {
            if (isEmpty())
                throw new Exception();

            var previous = first;
            var current = first.next;
            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.next = null;
            first = previous;
        }

        private bool isEmpty()
        {
            return first == null;
        }

        private MyNode getPrevious(MyNode node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        }
    }
}