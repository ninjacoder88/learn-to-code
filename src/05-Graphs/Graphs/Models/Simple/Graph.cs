using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    {
        public Graph()
        {
            _verticies = new List<Vertex>();
            _edges = new List<Edge>();
        }

        public IReadOnlyList<Vertex> Verticies => _verticies;

        public IReadOnlyList<Edge> Edges => _edges; 

        public void AddVertex(Vertex vertex)
        {
            _verticies.Add(vertex);
        }

        public void AddEdge(Vertex source, Vertex destination)
        {
            var edge = new Edge(source, destination);
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

        private List<Vertex> _verticies;
        private List<Edge> _edges;
    }
}