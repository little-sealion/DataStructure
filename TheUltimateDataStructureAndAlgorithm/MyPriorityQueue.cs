using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUltimateDataStructureAndAlgorithm
{
    public class MyPriorityQueue
    {
        private PQItem[] items;
        private int count;
        public MyPriorityQueue(int capacity)
        {
            items = new PQItem[capacity];
            count = 0;
        }
        public void Enqueue(PQItem item )
        {
            if (IsFull()) throw new InvalidOperationException("Queue is full");
            var i = ShiftItemToInsert(item);
            items[i] = item;
            count++;
        }

        public int ShiftItemToInsert(PQItem item)
        {
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (items[i].priority > item.priority)
                {
                    items[i + 1] = items[i];
                }
                else
                {
                    break;
                }
            }
            return i + 1;
        }

        public PQItem? DeQueue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is Empty");
            var result = items[0];
            for (int i = 0; i < count-1; i++)
            {
                items[i] = items[i + 1];
            }
            items[count - 1] = null;
            count--;
            return result;
        }

        public PQItem? Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is Empty");
            var result = items[0];
            return result;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public bool IsFull()
        {
            return count == items.Length;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append($"\nvalue:{items[i].value},priority:{items[i].priority}");
            }
            return sb.ToString();
        }

        public class PQItem
        {
            public int value { get;  }
            public int priority { get;  }
            public PQItem(int value,int priority)
            {
                this.value = value;
                this.priority = priority;
            }
        }
    }
}
