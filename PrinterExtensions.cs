﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHandler
{
    public static class PrinterExtensions
    {
        public static void Print<T>(this IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
