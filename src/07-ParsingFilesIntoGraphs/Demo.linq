<Query Kind="Program" />

void Main()
{
	string basePath = @"C:\code\learn-to-code\src\07-ParsingFilesIntoGraphs\ParsingFileIntoGraphs\data";
	string fileName = "city-distances.csv";
	string filePath = Path.Combine(basePath, fileName);

	FileParser fileParser = new FileParser();
	var items = fileParser.ParseFile(filePath).ToList();

	WeightedGraph graph = new WeightedGraph();
	Dictionary<string, WeightedVertex> dictionary = new Dictionary<string, WeightedVertex>();

	foreach (var item in items)
	{
		if (!dictionary.ContainsKey(item.StartCity))
		{
			var vertex = new WeightedVertex(item.StartCity);
			dictionary.Add(item.StartCity, vertex);
			graph.AddVertex(vertex);
		}

		if (!dictionary.ContainsKey(item.EndCity))
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

	foreach (var distance in distanceToCities)
	{
		Console.WriteLine(distance);
	}
}

public class WeightedGraph
{
	public WeightedGraph()
	{
		_verticies = new List<WeightedVertex>();
		_edges = new List<WeightedEdge>();
	}

	public IReadOnlyList<WeightedVertex> Verticies => _verticies;

	public IReadOnlyList<WeightedEdge> Edges => _edges;

	public void AddVertex(WeightedVertex vertex)
	{
		_verticies.Add(vertex);
	}

	public void AddEdge(WeightedVertex source, WeightedVertex destination, decimal distance)
	{
		var edge = new WeightedEdge(source, destination, distance);
		_edges.Add(edge);
		source.AddEdge(edge);
	}

	public void DisplayVerticies()
	{
		foreach (var vertex in Verticies)
			Console.WriteLine(vertex.Name);
	}

	public void DisplayEdges()
	{
		foreach (var edge in Edges)
			Console.WriteLine(edge.ToString());
	}

	private List<WeightedVertex> _verticies;
	private List<WeightedEdge> _edges;
}

public class FileParser
{
	public IEnumerable<Item> ParseFile(string filePath)
	{
		foreach (var fileLine in File.ReadAllLines(filePath))
		{
			var splitFileLine = fileLine.Split(",", StringSplitOptions.None);

			yield return new Item
			{
				StartCity = splitFileLine[0],
				EndCity = splitFileLine[1],
				Distance = decimal.Parse(splitFileLine[2])
			};
		}
	}
}

public class DijkstrasAlgorithm
{
	public List<string> Find(WeightedGraph g, WeightedVertex source)
	{
		List<WeightedVertex> unvisited = new List<WeightedVertex>();
		Dictionary<WeightedVertex, decimal> dist = new Dictionary<WeightedVertex, decimal>();
		Queue<WeightedVertex> path = new Queue<WeightedVertex>();

		foreach (var vertex in g.Verticies)
		{
			if (vertex == source)
				dist.Add(vertex, 0);
			else
				dist.Add(vertex, decimal.MaxValue);

			unvisited.Add(vertex);
		}

		unvisited.Remove(source);
		path.Enqueue(source);

		while (unvisited.Count > 0)
		{
			foreach (var vertex in path)
			{
				foreach (var edge in vertex.Edges)
				{
					var d = dist[vertex] + edge.Distance;
					if (d < dist[edge.Destination])
						dist[edge.Destination] = d;
				}
			}

			decimal minimumDistance = decimal.MaxValue;
			WeightedVertex closestVertex = null;
			foreach (var entry in dist)
			{
				if (!unvisited.Contains(entry.Key))
					continue;
				if (entry.Value < minimumDistance)
				{
					minimumDistance = entry.Value;
					closestVertex = entry.Key;
				}
			}

			unvisited.Remove(closestVertex);
			path.Enqueue(closestVertex);
		}

		List<string> distances = new List<string>();

		foreach (var entry in dist)
		{
			distances.Add($"{entry.Key.Name} -> {entry.Value}");
		}

		return distances;
	}
}

public class Item
{
	public string StartCity { get; set; }
	public string EndCity { get; set; }
	public decimal Distance { get; set; }
	public int TimeInMinutes { get; set; }
}

public class WeightedEdge
{
	public WeightedEdge(WeightedVertex source, WeightedVertex destination, decimal distance)
	{
		Source = source;
		Destination = destination;
		Distance = distance;
	}

	public WeightedVertex Source { get; }

	public WeightedVertex Destination { get; }

	public decimal Distance { get; }

	public override string ToString()
	{
		return $"{Source.Name} => {Destination.Name}";
	}
}

public class WeightedVertex
{
	public WeightedVertex(string name)
	{
		Name = name;
		_edges = new List<WeightedEdge>();
	}

	public string Name { get; }

	public IReadOnlyList<WeightedEdge> Edges => _edges;

	public void AddEdge(WeightedEdge edge)
	{
		_edges.Add(edge);
	}

	private List<WeightedEdge> _edges;
}