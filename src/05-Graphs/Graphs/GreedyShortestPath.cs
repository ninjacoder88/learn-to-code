using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    public class GreedyShortestPath
    {
        public void Solve(Vertex source, string destination)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(source);

            //Dictionary<Vertex, bool> visited = new Dictionary<Vertex, bool>();
            //visited.Add(source, false);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current.Name);
                //visited[current] = true;

                if(current.Name == destination)
                    return;

                int shortestDistance = int.MaxValue;
                Vertex next = null;
                //look at neighbors
                foreach(var edge in current.Edges)
                {
                    //add vertex to dictionary
                    //if(!visited.ContainsKey(edge.Destination))
                    //    visited.Add(edge.Destination, false);

                    //if(visited[edge.Destination] == true)
                    //    continue;

                    //get distance between current and destination
                    int distance = 1;
                    if(distance < shortestDistance)
                    {
                        shortestDistance = distance;
                        next = edge.Destination;
                    }
                }

                queue.Enqueue(next);
            }
        }
    }
}