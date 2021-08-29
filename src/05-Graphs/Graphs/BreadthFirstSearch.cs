using System;
using System.Collections.Generic;

namespace Graphs
{
    public class BreadthFirstSearch
    {
        public void Traverse(Graph graph)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(graph.Verticies[0]);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current.Name);

                foreach(var edge in current.Edges)
                {
                    queue.Enqueue(edge.Destination);//note: this is interesting because it assumes we do not have a cycle
                }
            }
        }
    }
}