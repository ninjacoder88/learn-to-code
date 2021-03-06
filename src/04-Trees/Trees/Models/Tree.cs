using System.Collections.Generic;

namespace Trees
{
    public class Tree<T>
    {
        public Tree(Node<T> root)
        {
            Root = root;
        }

        public Node<T> Root {get;}

        private List<Node<T>> Nodes {get;set;}

        public void ListNodes()
        {
            foreach (var node in Nodes)
            {
                node.Dump();
            }
        }
    }
}