using System.Collections.Generic;

namespace Trees
{
    public class BinaryTree<T>
    {
        public BinaryTree(BinaryNode<T> root)
        {
            Root = root;
            Nodes = new List<BinaryNode<T>>();
        }

        public BinaryNode<T> Root {get;set;}

        private List<BinaryNode<T>> Nodes {get;set;}

        public void ListNodes()
        {
            foreach (var node in Nodes)
            {
                node.Dump();
            }
        }
    }
}