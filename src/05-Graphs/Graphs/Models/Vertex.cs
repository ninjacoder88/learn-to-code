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

        public ReadOnlyList<Edge> Edges => _edges;

        private List<Edge> _edges;
    }
}