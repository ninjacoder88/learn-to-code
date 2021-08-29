using System;
using System.Linq;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphDemo graphDemo = new GraphDemo();
            //graphDemo.Demo01();

            Graph graph = new GraphMaker().Make();

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            //bfs.Traverse(graph);
            //discuss the problems with basic BFS in a graph

            GreedyShortestPath greedyShortestPath = new GreedyShortestPath();
            greedyShortestPath.Solve(graph.Verticies.First(), "F");
            //discuss the problems with greedy shortest path
            //in GraphMaker change graph.AddEdge(B, D); with graph.AddEdge(B, C);

            //Dijkstra's Algorithm
            //Bellman-Ford Algorithm
            //Floyd-Warshall Algorithm
        }
    }
}
