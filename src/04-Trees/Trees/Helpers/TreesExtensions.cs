using System;

namespace Trees
{
    public static class TreesExtensions
    {
        public static void Dump<T>(this Node<T> node)
        {
            Console.WriteLine(node.Value);
        }

        public static void Dump<T>(this BinaryNode<T> node)
        {
            Console.WriteLine(node.Value);
        }

        public static void Dump<T>(this T item)
        {
            Console.WriteLine(item);
        }
    }
}