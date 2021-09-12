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

        public static void DumpList<T>(this List<T> list)
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

        public static void Dump<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            foreach(var entry in dictionary)
            {
                Console.Write($"{entry.Key} -> "); 
                entry.Value.Dump();//doesn't quite work the way i want yet
            }
        }

        public static void Dump<TKey, TValue>(this Dictionary<TKey, List<TValue>> dictionary)
        {
            foreach(var entry in dictionary)
            {
                Console.WriteLine($"{entry.Key} -> ");
                Console.WriteLine("[");
                entry.Value.Dump();
                Console.WriteLine("]");
            }
        }
    }
}