using System;
using System.Collections.Generic;
using System.IO;

namespace ParsingFilesIntoGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            string basePath = @"C:\code\learn-to-code\src\07-ParsingFilesIntoGraphs\ParsingFileIntoGraphs\data";
            string fileName = "city-distances.csv";
            string filePath = Path.Combine(basePath, fileName);

            FileParser fp = new FileParser();
            var items = fp.ParseFile(filePath);

            WeightedGraph g = new WeightedGraph();

            Dictionary<string, WeightedVertex> dictionary = new Dictionary<string, WeightedVertex>();

            foreach(var item in items)
            {
                if(!dictionary.ContainsKey(item.StartCity))
                {
                    var vertex = new WeightedVertex(item.StartCity);
                    dictionary.Add(item.StartCity, vertex);
                    g.AddVertex(vertex);
                }
                
                if (!dictionary.ContainsKey(item.EndCity))
                {
                    var vertex = new WeightedVertex(item.EndCity);
                    dictionary.Add(item.EndCity, vertex);
                    g.AddVertex(vertex);
                }
                
                var src = dictionary[item.StartCity];
                var dest = dictionary[item.EndCity];
                g.AddEdge(src, dest, item.Distance, item.TimeInMinutes);
            }

            DijkstrasAlgorithm dijkstrasAlgorithm = new DijkstrasAlgorithm();
            var output = dijkstrasAlgorithm.Find(g, g.Verticies[0]);

            foreach(var r in output)
            {
                Console.WriteLine(r);
            }
        }
    }
}
