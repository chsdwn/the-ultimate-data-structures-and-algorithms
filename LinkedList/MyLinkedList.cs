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

            if (first == null)
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }
    }
}