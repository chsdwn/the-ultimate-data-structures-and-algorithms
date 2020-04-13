using System.Collections.Generic;

namespace the_ultimate_data_structures_and_algorithms.LinkedList
{
    public class MyNode
    {
        private int value;
        private MyNode next;

        public MyNode(int value)
        {
            this.value = value;
            this.next = null;
        }

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        public MyNode GetNext()
        {
            return next;
        }

        public void SetNext(MyNode next)
        {
            this.next = next;
        }
    }
}