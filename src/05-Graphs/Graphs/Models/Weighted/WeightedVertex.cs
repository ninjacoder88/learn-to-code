using System.Collections.Generic;

namespace Graphs
{
    public class WeightedVertex
    {
        public WeightedVertex(string name)
        {
            Name = name;
            _edges = new List<WeightedEdge>();
        }

        public string Name {get;}

        public IReadOnlyList<WeightedEdge> Edges => _edges;

        public void AddEdge(WeightedEdge edge)
        {
            _edges.Add(edge);
        }

        private List<WeightedEdge> _edges;
    }
}