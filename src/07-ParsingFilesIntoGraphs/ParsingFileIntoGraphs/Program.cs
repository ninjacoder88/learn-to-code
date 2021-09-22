using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ParsingFilesIntoGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            string basePath = @"C:\code\learn-to-code\src\07-ParsingFilesIntoGraphs\ParsingFileIntoGraphs\data";
            string fileName = "city-distances.csv";
            string filePath = Path.Combine(basePath, fileName);

            FileParser fileParser = new FileParser();
            var items = fileParser.ParseFile(filePath).ToList();

            WeightedGraph graph = new WeightedGraph();
            Dictionary<string, WeightedVertex> dictionary = new Dictionary<string, WeightedVertex>();

            foreach(var item in items)
            {
                if(!dictionary.ContainsKey(item.StartCity))
                {
                    var vertex = new WeightedVertex(item.StartCity);
                    dictionary.Add(item.StartCity, vertex);
                    graph.AddVertex(vertex);
                }

                if(!dictionary.ContainsKey(item.EndCity))
                {
                    var vertex = new WeightedVertex(item.EndCity);
                    dictionary.Add(item.EndCity, vertex);
                    graph.AddVertex(vertex);
                }

                var src = dictionary[item.StartCity];
                var dest = dictionary[item.EndCity];
                graph.AddEdge(src, dest, item.Distance);
                //graph.AddEdge(dest, src, item.Distance); uncomment this line to make an undirected graph
            }

            DijkstrasAlgorithm dijkstrasAlgorithm = new DijkstrasAlgorithm();
            var distanceToCities = dijkstrasAlgorithm.Find(graph, graph.Verticies[4]);

            foreach(var distance in distanceToCities)
            {
                Console.WriteLine(distance);
            }
        }
    }
}
