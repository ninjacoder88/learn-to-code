namespace Graphs
{
    public class GraphDemo
    {
        //create some verties and edges, add to graph and display edges
        public void Demo01()
        {
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");

            Graph g = new Graph();
            g.AddVertex(A);
            g.AddVertex(B);
            g.AddVertex(C);
            g.AddVertex(D);
            g.AddEdge(A, B);
            g.AddEdge(B, C);
            g.AddEdge(C, D);
            g.DisplayEdges();
        }

        //add more verticies and edges
        public void Demo02()
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

            graph.DisplayEdges();
        }
    }
}