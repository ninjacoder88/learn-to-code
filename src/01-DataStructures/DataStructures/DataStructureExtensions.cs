using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataStructures
{
    public static class DataStructureExtensions
    {
        public static void Dump<T>(this T item)
        {
            Console.WriteLine(item.ToString());
        }

        public static void Dump<T>(this T[] array)
        {
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void Dump<T>(this List<T> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void Dump<T>(this Collection<T> collection)
        {
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void Dump<T>(this Stack<T> stack)
        {
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        public static void Dump<T>(this Queue<T> queue)
        {
            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        public static void Dump<T>(this LinkedList<T> linkedList)
        {
            var current = linkedList.First;

            while(current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}