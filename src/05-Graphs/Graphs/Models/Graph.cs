namespace Graphs
{
    public class Graph
    {
        public Graph()
        {
            Verticies = new List<Vertex>();
        }

        public List<Vertex> Verticies {get;}

        public void AddVertex(string name)
        {
            Verticies.Add(new Vertex(name));
        }
    }
}