namespace Graphs
{
    public class Edge
    {
        public Edge(Vertex source, Vertex destination)
        {
            Source = source;
            Destination = destination;
        }

        public Vertex Source {get;}

        public Vertex Destination {get;}

        public override string ToString()
        {
            return $"{Source.Name} => {Destination.Name}";
        }
    }
}