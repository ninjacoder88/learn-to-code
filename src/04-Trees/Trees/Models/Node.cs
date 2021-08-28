using System.Collections.Generic;

namespace Trees
{
    public class Node<T>
    {
        public Node(T value)
        {
            Children = new List<Node<T>>();
        }

        public T Value {get;}

        public List<Node<T>> Children {get;}

        public void AddChild(Node<T> node)
        {
            Children.Add(node);
        }
    }
}