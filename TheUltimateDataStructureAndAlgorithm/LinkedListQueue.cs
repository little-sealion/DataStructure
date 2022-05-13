  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUltimateDataStructureAndAlgorithm
{
    public class LinkedListQueue
    {
        private LinkedList<int> queue;
        public LinkedListQueue()
        {
            queue = new LinkedList<int>();
        }
        public void Enqueue(int item)
        {
            var node = new LinkedListNode<int> (item);           
            queue.AddLast(node);
        }
        public int Dequeue()
        {
            if(IsEmpty()) throw new InvalidOperationException("Queue is empty");
            int result = queue.First.Value;
            queue.RemoveFirst();
            return result;
        }
        public int Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");
            int result = queue.First.Value;
            return result;
        }
        public bool IsEmpty()
        {
            return queue.Count == 0;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            while (queue.Count>0)
            {
                sb.Append(queue.First.Value);
                queue.RemoveFirst();
            }
            return sb.ToString();
        }
    }
}
