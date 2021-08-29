namespace Graphs
{
    public class GraphMaker
    {
        public Graph Make()
        {
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");

            Graph graph = new Graph();
            graph.AddVertex(A);
            graph.AddVertex(B);
            graph.AddVertex(C);
            graph.AddVertex(D);
            graph.AddVertex(E);
            graph.AddVertex(F);

            graph.AddEdge(A, B);
            graph.AddEdge(B, C);
            graph.AddEdge(C, D);
            graph.AddEdge(B, D);
            graph.AddEdge(D, E);
            graph.AddEdge(E, F);
            graph.AddEdge(C, F);

            return graph;
        }
    }
}