namespace ParsingFilesIntoGraphs
{
    public class WeightedEdge
    {
        public WeightedEdge(WeightedVertex source, WeightedVertex destination, decimal distance)
        {
            Source = source;
            Destination = destination;
            Distance = distance;
        }

        public WeightedVertex Source {get;}

        public WeightedVertex Destination {get;}

        public decimal Distance {get;}

        public override string ToString()
        {
            return $"{Source.Name} => {Destination.Name}";
        }
    }
}