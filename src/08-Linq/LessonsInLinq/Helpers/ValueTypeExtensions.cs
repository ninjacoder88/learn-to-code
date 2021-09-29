using System;

namespace LessonsInLinq
{
    public static class ValueTypeExtensions
    {
        public static void Dump(this bool value)
        {
            Console.WriteLine(value);
        }

        public static void Dump(this string value)
        {
            Console.WriteLine(value);
        }

        public static void Dump(this decimal value)
        {
            Console.WriteLine(value);
        }
    }
}