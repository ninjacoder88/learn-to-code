using System.Collections.Generic;

namespace Trees
{
    public class DepthFirstSearch
    {
        public void Traverse<T>(Tree<T> tree)
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(tree.Root);

            while(stack.Count > 0)
            {
                var current = stack.Pop();
                current.Dump();

                foreach(var child in current.Children)
                    stack.Push(child);
            }
        }
    }
}