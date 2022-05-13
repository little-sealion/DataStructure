using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUltimateDataStructureAndAlgorithm
{
    public class QueueReverser
    {
        private Stack<int> stack;
        public void reverse(Queue<int> queue, int k)
        {
            if (k > queue.Count) throw new InvalidOperationException($"K {k} is larger than queue.Count {queue.Count}");
            stack = new Stack<int>(k);
            var count = queue.Count;
            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }
            for (int i = 0; i < k; i++)
            {
                queue.Enqueue(stack.Pop());
            }
            for (int i = 0; i < count - k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }
    }
}
