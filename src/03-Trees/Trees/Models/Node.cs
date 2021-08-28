namespace Trees
{
    public class Node<T>
    {
        public Node()
        {
            Children = new List<Node<T>>();
        }

        public T Value {get;set;}

        public List<Node<T>> Children {get;set;}
    }
}