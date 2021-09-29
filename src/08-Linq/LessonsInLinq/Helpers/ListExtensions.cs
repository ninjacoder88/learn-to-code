using System;
using System.Collections.Generic;

namespace LessonsInLinq
{
    public static class ListExtensions
    {
        public static void Dump<T>(this List<T> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}