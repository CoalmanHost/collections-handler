using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHandler
{
    public static class Extensions
    {
        public static void Print<T>(this IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
        }
        public static string GetStringRepresentation<T>(this IEnumerable<T> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
