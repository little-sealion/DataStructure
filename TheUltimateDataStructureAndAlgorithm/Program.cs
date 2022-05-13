using TheUltimateDataStructureAndAlgorithm;

string str = "orange-apple";
Console.WriteLine(str.GetHashCode());
int hash(string key)
{
    int hash = 0;
    foreach (var ch in key)
    {
        hash += ch;
    }
    return hash % 100;
}
Console.WriteLine(hash("123456-A"));
/*var finder = new CharFinder();
var firstNonRep = finder.GetFirstNonRepetitiveChar("a green apple");
Console.WriteLine(firstNonRep);
var firstRep = finder.GetFirstRepetitiveChar("a green apple");
Console.WriteLine(firstRep);*/

/*var queue = new LinkedListQueue();
queue.Enqueue(5);
queue.Enqueue(4);
queue.Enqueue(3);
queue.Enqueue(7);
queue.Enqueue(1);
queue.Dequeue();
Console.WriteLine(queue.ToString());
*/
/*var originalQueue = new Queue<int>();
originalQueue.Enqueue(1);
originalQueue.Enqueue(4);
originalQueue.Enqueue(9);
originalQueue.Enqueue(3);

var queueReverser = new QueueReverser();
queueReverser.reverse(originalQueue, 3);
while (originalQueue.Count > 0)
{
    Console.WriteLine(originalQueue.Dequeue());
}*/
/*using static TheUltimateDataStructureAndAlgorithm.MyPriorityQueue;

var mpq = new MyPriorityQueue(5);
mpq.Enqueue(new PQItem(1, 1));
mpq.Enqueue(new PQItem(4, 4));
mpq.Enqueue(new PQItem(3, 3));
mpq.Enqueue(new PQItem(6, 6));
mpq.Enqueue(new PQItem(2, 2));
mpq.DeQueue();
mpq.Enqueue(new PQItem(5, 5));
Console.WriteLine(mpq.ToString());*/


/*PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
queue.Enqueue(3, 3);
queue.Enqueue(5, 5);
queue.Enqueue(1, 1);
queue.Enqueue(6, 6);

while(queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}*/

