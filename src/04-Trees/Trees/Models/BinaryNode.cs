namespace Trees
{
    public class BinaryNode<T>
    {
        public BinaryNode(T value)
        {
            Value = value;
        }

        public T Value {get;set;}

        public BinaryNode<T> Left {get;set;}

        public BinaryNode<T> Right {get;set;}
    }
}