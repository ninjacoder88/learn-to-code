namespace ParsingFilesIntoGraphs
{
    public class WeightedEdge
    {
        public WeightedEdge(WeightedVertex source, WeightedVertex destination, decimal distance, int time)
        {
            Source = source;
            Destination = destination;
            Distance = distance;
            Time = time;
        }

        public WeightedVertex Source {get;}

        public WeightedVertex Destination {get;}

        public decimal Distance {get;}

        public int Time {get;}

        public override string ToString()
        {
            return $"{Source.Name} => {Destination.Name}";
        }
    }
}