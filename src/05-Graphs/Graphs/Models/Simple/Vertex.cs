using System.Collections.Generic;

namespace Graphs
{
    public class Vertex
    {
        public Vertex(string name)
        {
            Name = name;
            _edges = new List<Edge>();
        }

        public string Name {get;}

        public IReadOnlyList<Edge> Edges => _edges;

        public void AddEdge(Edge edge)
        {
            _edges.Add(edge);
        }

        private List<Edge> _edges;
    }
}