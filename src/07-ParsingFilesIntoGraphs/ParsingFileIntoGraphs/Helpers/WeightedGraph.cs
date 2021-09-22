using System;
using System.Collections.Generic;

namespace ParsingFilesIntoGraphs
{
    public class WeightedGraph
    {
        public WeightedGraph()
        {
            _verticies = new List<WeightedVertex>();
            _edges = new List<WeightedEdge>();
        }

        public IReadOnlyList<WeightedVertex> Verticies => _verticies;

        public IReadOnlyList<WeightedEdge> Edges => _edges; 

        public void AddVertex(WeightedVertex vertex)
        {
            _verticies.Add(vertex);
        }

        public void AddEdge(WeightedVertex source, WeightedVertex destination, decimal distance, int time)
        {
            var edge = new WeightedEdge(source, destination, distance, time);
            _edges.Add(edge);
            source.AddEdge(edge);
        }

        public void DisplayVerticies()
        {
            foreach(var vertex in Verticies)
                Console.WriteLine(vertex.Name);
        }

        public void DisplayEdges()
        {
            foreach(var edge in Edges)
                Console.WriteLine(edge.ToString());
        }

        private List<WeightedVertex> _verticies;
        private List<WeightedEdge> _edges;
    }
}