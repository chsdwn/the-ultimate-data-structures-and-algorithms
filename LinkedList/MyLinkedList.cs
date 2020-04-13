namespace the_ultimate_data_structures_and_algorithms.LinkedList
{
    public class MyLinkedList
    {
        private MyNode first;
        private MyNode last;
        private int count;

        public MyLinkedList()
        {
            first = null;
            last = null;
        }

        // addFirst
        public void AddFirst(int value)
        {
            count++;
            var item = new MyNode(value);

            if (count == 1)
            {
                first = item;
                last = item;
                return;
            }

            if (first != null)
                item.SetNext(first);

            first = item;
        }

        // addLast
        public void AddLast(int value)
        {
            count++;
            var item = new MyNode(value);

            if (count == 1)
            {
                first = item;
                last = item;
                return;
            }

            if (last != null)
                last.SetNext(item);

            last = item;
        }

        // deleteFirst
        public void DeleteFirst()
        {
            count--;
            var newFirst = first.GetNext();

            if (count == 1)
            {
                first = newFirst;
                last = newFirst;
                return;
            }

            first = newFirst;
        }

        // deleteLast
        public void DeleteLast()
        {
            count--;
            if (count == 1)
            {
                last = first;
                return;
            }

            var newLast = first;
            for (int i = 0; i < count - 1; i++)
            {
                newLast = newLast.GetNext();
            }

            last = newLast;
        }
        // contains
        public bool Contains(int value)
        {
            var item = first;
            for (int i = 0; i < count - 1; i++)
            {
                if (value == item.GetValue())
                    return true;
                item = item.GetNext();
            }
            return false;
        }

        // indexOf
        public int IndexOf(int value)
        {
            var item = first;
            for (int i = 0; i < count - 1; i++)
            {
                if (value == item.GetValue())
                    return i;
                item = item.GetNext();
            }
            return -1;
        }

        public void Print()
        {
            var item = first;
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine(item.GetValue());
                item = item.GetNext();
            }
        }
    }
}