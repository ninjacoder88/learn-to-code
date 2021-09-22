using System;
using System.Collections.Generic;

namespace ParsingFilesIntoGraphs
{
    public class DijkstrasAlgorithm
    {
        public List<string> Find(WeightedGraph g, WeightedVertex source)
        {
            List<WeightedVertex> unvisited = new List<WeightedVertex>();
            Dictionary<WeightedVertex, decimal> dist = new Dictionary<WeightedVertex, decimal>();
            Queue<WeightedVertex> path = new Queue<WeightedVertex>();

            foreach(var vertex in g.Verticies)
            {
                if(vertex == source)
                    dist.Add(vertex, 0);
                else
                    dist.Add(vertex, decimal.MaxValue);
                
                unvisited.Add(vertex);
            }

            unvisited.Remove(source);
            path.Enqueue(source);

            while(unvisited.Count > 0)
            {
                foreach(var vertex in path)
                {
                    foreach(var edge in vertex.Edges)
                    {
                        var d = dist[vertex] + edge.Distance;
                        if(d < dist[edge.Destination])
                            dist[edge.Destination] = d;
                    }
                }

                decimal minimumDistance = decimal.MaxValue;
                WeightedVertex closestVertex = null;
                foreach(var entry in dist)
                {
                    if(!unvisited.Contains(entry.Key))
                        continue;
                    if(entry.Value < minimumDistance)
                    {
                        minimumDistance = entry.Value;
                        closestVertex = entry.Key;
                    }
                }

                unvisited.Remove(closestVertex);
                path.Enqueue(closestVertex);
            }

            List<string> distances = new List<string>();

            foreach(var entry in dist)
            {
                distances.Add($"{entry.Key.Name} -> {entry.Value}");
            }

            return distances;
        }
    }
}