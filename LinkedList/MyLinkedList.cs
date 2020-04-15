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

        public int getKthFromTheEnd(int k)
        {
            if (isEmpty()) throw new Exception();

            var a = first;
            var b = first;

            for (int i = 0; i < k - 1; i++)
            {
                b = b.next;
                if (b == null) throw new Exception();
            }

            while (b != last)
            {
                a = a.next;
                b = b.next;
            }

            return a.value;
        }

        public void printMiddle()
        {
            var step = 0;
            var current = first;
            var middle = first;
            while (current != null)
            {
                if (step % 2 == 0 && step != 0)
                    middle = middle.next;

                current = current.next;
                step++;
            }

            if (step % 2 == 0) Console.WriteLine($"{middle.value}, {middle.next.value}");
            else Console.WriteLine($"{middle.value}");
        }

        public bool hasLoop()
        {
            var step = 0;
            var fast = first;
            var slow = first;
            while (slow != last)
            {
                if (fast.next == null) return false;

                if (step % 2 == 0 && step != 0)
                    slow = slow.next;

                fast = fast.next;

                if (fast == slow && fast != first) return true;

                step++;
            }
            return false;
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