using System.Collections.Generic;

namespace DataStructures
{
    public class QueueDemo
    {
        //initialize and populate queue
        public void Demo01()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dump();
        }

        //create a queue of different type and size
        public void Demo02()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Enqueue("D");

            queue.Dump();
        }

        //retrieve values from the queue
        public void Demo03()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            
            queue.Dequeue().Dump();
            queue.Dequeue().Dump();
            queue.Dequeue().Dump();
        }
    }
}