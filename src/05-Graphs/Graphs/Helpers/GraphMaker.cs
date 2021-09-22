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

        public WeightedGraph MakeWeighted()
        {
            WeightedVertex zero = new WeightedVertex("0");
            WeightedVertex one = new WeightedVertex("1");
            WeightedVertex two = new WeightedVertex("2");
            WeightedVertex three = new WeightedVertex("3");
            WeightedVertex four = new WeightedVertex("4");
            WeightedVertex five = new WeightedVertex("5");
            WeightedVertex six = new WeightedVertex("6");

            WeightedGraph g = new WeightedGraph();
            g.AddVertex(zero);
            g.AddVertex(one);
            g.AddVertex(two);
            g.AddVertex(three);
            g.AddVertex(four);
            g.AddVertex(five);
            g.AddVertex(six);

            g.AddEdge(zero, one, 2, 2);
            g.AddEdge(zero, two, 6, 6);
            g.AddEdge(one, three, 5, 5);
            g.AddEdge(two, three, 8, 8);
            g.AddEdge(three, four, 10, 10);
            g.AddEdge(three, five, 15, 15);
            g.AddEdge(four, five, 6, 6);
            g.AddEdge(four, six, 2, 2);
            g.AddEdge(five, six, 6, 6);

            return g;
        }
    }
}