namespace the_ultimate_data_structures_and_algorithms.LinkedList
{
    public class MyLinkedList
    {
        private class MyNode
        {
            private int value;
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

        private bool isEmpty()
        {
            return first == null;
        }
    }
}