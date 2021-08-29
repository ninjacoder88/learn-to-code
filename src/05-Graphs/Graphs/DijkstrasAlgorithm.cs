using System.Collections.Generic;

namespace Graphs
{
    public class DijkstrasAlgorithm
    {
        public void Traverse(Vertex start, string destination)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(start);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();

                int minimumDistance = int.MaxValue;
                Vertex next = null;

                foreach(var edge in start.Edges)
                {
                    //check if vertex has been visited, if not queue and check distance

                    //find the closest vertex
                    int distance = 1;
                    if(distance < minimumDistance)
                    {
                        minimumDistance = distance;
                        next = edge.Destination;
                    }
                }

                //repeat with next
            }
        }
    }
}