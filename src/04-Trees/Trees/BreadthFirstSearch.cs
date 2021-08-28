using System.Collections.Generic;

namespace Trees
{
    public class BreadthFirstSearch
    {
        public void Traverse<T>(Tree<T> tree)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(tree.Root);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                current.Dump();

                foreach(var child in current.Children)
                    queue.Enqueue(child);
            }
        }
    }
}